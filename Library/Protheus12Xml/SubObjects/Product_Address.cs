namespace Gesk.Library.Protheus12Xml.SubObjects
{
    public class Product_Address
    {
        public string CodeBSC { get; set; }
        public string Address { get; set; }

        public Product_Address(string codeBSC, string address)
        {
            CodeBSC = codeBSC;
            Address = address;
        }
    }
}
