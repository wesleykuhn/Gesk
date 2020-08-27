using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Gesk.Library.Serialization
{
    public static class Desserialize
    {
        private static T DesserializePath<T>(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));

            StreamReader sr = new StreamReader(path, Encoding.UTF8);      

            return (T)xs.Deserialize(sr);
        }

        public static Address DesserializeAddress(string path)
        {
            return DesserializePath<Address>(path);
        }

        public static Product DesserializeProducts(string path)
        {
            return DesserializePath<Product>(path);
        }

        public static Kit DesserializeKits(string path)
        {
            return DesserializePath<Kit>(path);
        }
    }
}
