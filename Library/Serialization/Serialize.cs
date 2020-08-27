using Gesk.Library.Objects.SubObjects;
using System.Xml.Serialization;
using System.IO;
using System;
using System.Collections.Generic;
using Gesk.Library.Objects;
using System.Text;

namespace Gesk.Library.Serialization
{
    public static class Serialize
    {
        public static bool Addresses(Address[] addresses)
        {
            try
            {
                foreach (Address address in addresses)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Address));

                    StreamWriter sw = new StreamWriter(InformationsCore.Directories.Addresses + address.Id.ToString() + ".xml");

                    serializer.Serialize(sw, address);
                }
            }
            catch (Exception ex)
            {
                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;                       
        }

        public static bool Addresses(List<Address> addresses)
        {
            try
            {
                foreach (Address address in addresses)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Address));

                    StreamWriter sw = new StreamWriter(InformationsCore.Directories.Addresses + address.Id.ToString() + ".xml");

                    serializer.Serialize(sw, address);
                }
            }
            catch (Exception ex)
            {
                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }

        public static bool Product(Product product)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Product));

                StreamWriter sw = new StreamWriter(InformationsCore.Directories.Products + product.Id.ToString() + ".xml", false, Encoding.UTF8);

                serializer.Serialize(sw, product);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar gravar um arquivo no dispositivo, veja o arquivo log.txt para mais detalhes.", "Erro");

                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }

        public static bool Products(Product[] products)
        {
            try
            {
                foreach (Product product in products)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Product));

                    StreamWriter sw = new StreamWriter(InformationsCore.Directories.Products + product.Id.ToString() + ".xml", false, Encoding.UTF8);

                    serializer.Serialize(sw, product);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar gravar um arquivo no dispositivo, veja o arquivo log.txt para mais detalhes.", "Erro");

                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }

        public static bool Products(List<Product> products)
        {
            try
            {
                foreach (Product product in products)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Product));

                    StreamWriter sw = new StreamWriter(InformationsCore.Directories.Products + product.Id.ToString() + ".xml", false, Encoding.UTF8);

                    serializer.Serialize(sw, product);
                }
            }
            catch (Exception ex)
            {
                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }

        public static bool Kit(Kit kit)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Kit));

                StreamWriter sw = new StreamWriter(InformationsCore.Directories.Kits + kit.Id.ToString() + ".xml", false, Encoding.UTF8);

                serializer.Serialize(sw, kit);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar gravar um arquivo no dispositivo, veja o arquivo log.txt para mais detalhes.", "Erro");

                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }

        public static bool Kits(List<Kit> kits)
        {
            try
            {
                foreach (Kit kit in kits)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Kit));

                    StreamWriter sw = new StreamWriter(InformationsCore.Directories.Products + kit.Id.ToString() + ".xml", false, Encoding.UTF8);

                    serializer.Serialize(sw, kit);
                }
            }
            catch (Exception ex)
            {
                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);

                return false;
            }

            return true;
        }
    }
}
