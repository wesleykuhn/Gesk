using System.Collections.Generic;

namespace Gesk.Library.Protheus12Xml.SubObjects
{
    public class Duplicate
    {
        public string CodeBSC { get; set; }
        public List<int> Addresses_Id = new List<int>();

        public Duplicate(string codeBSC, int[] addressIds)
        {
            this.CodeBSC = codeBSC;
            this.Addresses_Id.AddRange(addressIds);
        }
    }
}
