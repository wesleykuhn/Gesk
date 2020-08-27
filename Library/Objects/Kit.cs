using Gesk.Library.Objects.SubObjects;
using System.Collections.Generic;

namespace Gesk.Library.Objects
{
    public class Kit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<KitProduct> KitProducts = new List<KitProduct>();

        public Kit(){}

        public Kit(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
