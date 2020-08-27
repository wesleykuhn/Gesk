using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gesk.Library.Protheus12Xml
{
    public class Reader
    {
        string Path { get; set; }
        internal int TotalRows { get; set; }
        internal int TotalCells { get; set; }

        public Reader(string path)
        {
            this.Path = path;
        }

        private string ReadXmlGrossRows(string spliterString)
        {
            string document = CustomStream.Reader.ReadAllDocument(this.Path, Encoding.UTF8); //1252

            int startIndex = document.IndexOf(spliterString);
            startIndex += 28 + spliterString.Length;

            int endIndex = document.IndexOf("</Table>", startIndex);
            endIndex -= 3;

            return document.Substring(startIndex, endIndex - startIndex);       
        }

        private string[] DivideGrossRowsToRows(string grossRows)
        {
            string[] rows;
            if (!grossRows.Contains("<Row>"))
            {
                rows = grossRows.Split(new string[] { "<Row ", "</Row>" }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                rows = grossRows.Split(new string[] { "<Row>", "</Row>" }, StringSplitOptions.RemoveEmptyEntries);
            }            

            //Avoid using empty rows
            return rows.Where(x => x.Trim() != "").Select(x => x).ToArray();
        }

        private string[] DivideRowToData(string row)
        {
            string[] cells = row.Split(new string[] { "<Cell ", "</Cell>" }, StringSplitOptions.RemoveEmptyEntries);
            //Avoid using empty rows
            cells = cells.Where(x => x.Trim() != "").Select(x => x).ToArray();

            //Clear the invalid rows
            cells = cells.Where(x => x.Contains("<Data")).Select(x => x).ToArray();

            //Nesse momento temos algo como isso: ss:StyleID="s62"><Data ss:Type="String">B182245VG3/8</Data>
            //Converting to data
            string data;
            for (int i = 0; i < cells.Length; i++)
            {
                int startIndex = cells[i].IndexOf("<Data");
                startIndex = cells[i].IndexOf('>', startIndex) + 1;

                int endIndex = cells[i].IndexOf("</Data>");

                data = cells[i].Substring(startIndex, endIndex - startIndex);
                //Nesse momento temos algo como isso: B182245VG3/8

                cells[i] = data;
            }

            return cells;
        }        

        public List<SubObjects.Duplicate> UpdateProductsAddresses()
        {
            List<SubObjects.Duplicate> duplicates = new List<SubObjects.Duplicate>();
            List<SubObjects.Product_Address> products_address = new List<SubObjects.Product_Address>();

            string[] rows = this.DivideGrossRowsToRows(this.ReadXmlGrossRows("Endereco"));
            foreach (string row in rows)
            {
                string[] data = this.DivideRowToData(row);

                products_address.Add(new SubObjects.Product_Address(data[0], data[1]));
            }

            foreach (SubObjects.Product_Address pa in products_address)
            {                
                // Address doesnt exist
                if (!GlobalVariables.Addresses.Exists(x => x.ToString() == pa.Address)) continue;
                
                int index = GlobalVariables.Addresses.FindIndex(x => x.ToString() == pa.Address);
                int addressId = GlobalVariables.Addresses[index].Id;

                // Product doesnt exist
                if (!GlobalVariables.Products.Exists(x => x.CodeBSC == pa.CodeBSC)) continue;

                // Sometimes we have two or more Client Code for one BSC code, then we do one by one
                int[] productsIds = GlobalVariables.Products.Where(x => x.CodeBSC == pa.CodeBSC).Select(x => x.Id).ToArray();
                if(productsIds.Length > 1)
                {
                    foreach (int id in productsIds)
                    {
                        // Not have it yet
                        if (GlobalVariables.Products[id].Address_Id < 0) GlobalVariables.Products[id].Address_Id = addressId;

                        // Have one but it's diferent - Duplicate
                        else if (GlobalVariables.Products[id].Address_Id >= 0 && Address.GetAddressString(GlobalVariables.Products[id].Address_Id) != pa.Address)
                        {
                            index = duplicates.FindIndex(x => x.CodeBSC == pa.CodeBSC);
                            if (index < 0)
                            {
                                duplicates.Add(new SubObjects.Duplicate(GlobalVariables.Products[id].CodeBSC, new int[] { GlobalVariables.Products[id].Address_Id, addressId }));
                            }
                            else
                            {
                                duplicates[index].Addresses_Id.Add(addressId);
                            }                            
                        }

                        // It's equals or error
                        else continue;
                    }
                }
                else
                {
                    index = GlobalVariables.Products.FindIndex(x => x.CodeBSC == pa.CodeBSC);

                    // Not have it yet
                    if (GlobalVariables.Products[index].Address_Id < 0) GlobalVariables.Products[index].Address_Id = addressId;

                    // Have one but it's diferent - Duplicate
                    else if (GlobalVariables.Products[index].Address_Id >= 0 && Address.GetAddressString(GlobalVariables.Products[index].Address_Id) != pa.Address) duplicates.Add(new SubObjects.Duplicate(GlobalVariables.Products[index].CodeBSC, new int[] { GlobalVariables.Products[index].Address_Id, addressId }));

                    // It's equals or error
                    else continue;
                }
                                
            }

            return duplicates;
        }

        public List<Product> XmlToProducts()
        {
            List<Product> products = new List<Product>();

            string[] rows = this.DivideGrossRowsToRows(this.ReadXmlGrossRows("Descr.Client"));

            // Telemetry
            this.TotalRows = rows.Length;

            //To count total cells
            bool oneTimeCalculation = true;

            foreach (string row in rows)
            {
                string[] data = this.DivideRowToData(row);

                //Count the total of cells
                if (oneTimeCalculation)
                {
                    this.TotalCells = TotalRows * data.Length;

                    oneTimeCalculation = false;
                }

                products.Add(new Product(-1, data[0], data[2], data[1], 0, -1, 0, 0, 0, true));
            }

            return products;
        }
    }
}
