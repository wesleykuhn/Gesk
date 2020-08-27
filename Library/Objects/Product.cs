using System.Linq;

namespace Gesk.Library.Objects
{
    public class Product
    {
        public int Id { get; set; }
        public string CodeBSC { get; set; }
        public string Description { get; set; }
        public string CodeClient { get; set; }
        public int Stock { get; set; }
        public int Address_Id { get; set; }
        public int Demand { get; set; }
        public int DailyConsuption { get; set; }
        public int Billed { get; set; }      
        public bool Status { get; set; }
        

        public Product(){}

        public Product(int id, string codeBSC, string description, string codeClient)
        {
            Id = id;
            CodeBSC = codeBSC;
            Description = description;
            CodeClient = codeClient;
        }

        public Product(int id, string codeBSC, string description, string codeClient, int stock, int address_Id, int demand, int dailyConsuption, int billed, bool status)
        {
            Id = id;
            CodeBSC = codeBSC;
            Description = description;
            CodeClient = codeClient;
            Stock = stock;
            Address_Id = address_Id;
            Demand = demand;
            DailyConsuption = dailyConsuption;
            Billed = billed;
            Status = status;           
        }

        public static Product CloneProduct(int id)
        {
            if (id < 0) return null;

            int index = GlobalVariables.Products.FindIndex(x => x.Id == id);

            if (index < 0) return null;
            else return GlobalVariables.Products[index];
        }

        public static Product CloneProduct(string codeClient)
        {
            int index = GlobalVariables.Products.FindIndex(x => x.CodeClient == codeClient);

            // Not is exactly
            if (index < 0)
            {
                // Before for() = FA112030
                string newCode = "";
                for (int i = 0; i < 10 - codeClient.Length; i++)
                {
                    newCode += '0';
                }
                newCode += codeClient;
                // After for() = 00FA112030

                index = GlobalVariables.Products.FindIndex(x => x.CodeClient == newCode);
                if (index < 0) return null;
                else return GlobalVariables.Products[index];
            }
            else return GlobalVariables.Products[index];
        }
    }
}
