using System.IO;
using System.Linq;

namespace Gesk.Library.Checker
{
    public static class StartUp
    {
        public static void MakeCheckUps()
        {
            CheckDirectories();

            ReadAddresses();
            ReadProducts();
            ReadKits();

            GetFreeIds();
        }

        private static void ReadAddresses()
        {
            string[] files = Directory.GetFiles(InformationsCore.Directories.Addresses);
            foreach(string file in files)
            {
                if (!Validator.StringHasNumber(file) || !file.Contains(".xml")) continue;

                GlobalVariables.Addresses.Add(Serialization.Desserialize.DesserializeAddress(file));
            }
        }

        private static void ReadProducts()
        {
            string[] files = Directory.GetFiles(InformationsCore.Directories.Products);
            foreach (string file in files)
            {
                if (!Validator.StringHasNumber(file) || !file.Contains(".xml")) continue;

                GlobalVariables.Products.Add(Serialization.Desserialize.DesserializeProducts(file));
            }
        }

        private static void ReadKits()
        {
            string[] files = Directory.GetFiles(InformationsCore.Directories.Kits);
            foreach (string file in files)
            {
                if (!Validator.StringHasNumber(file) || !file.Contains(".xml")) continue;

                GlobalVariables.Kits.Add(Serialization.Desserialize.DesserializeKits(file));
            }
        }

        private static void CheckDirectories()
        {
            if (!Directory.Exists(@".\Addresses")) Directory.CreateDirectory(@".\Addresses");
            if (!Directory.Exists(@".\Products")) Directory.CreateDirectory(@".\Products");
            if (!Directory.Exists(@".\Kits")) Directory.CreateDirectory(@".\Kits");
        }

        private static void GetFreeIds()
        {
            if(GlobalVariables.Addresses.Count > 0)
            {
                int i = GlobalVariables.Addresses.Max(x => x.Id);
                GlobalVariables.CurrentFreeAddressId = i + 1;
            }

            if (GlobalVariables.Products.Count > 0)
            {
                int i = GlobalVariables.Products.Max(x => x.Id);
                GlobalVariables.CurrentFreeProductsId = i + 1;
            }

            if (GlobalVariables.Kits.Count > 0)
            {
                int i = GlobalVariables.Kits.Max(x => x.Id);
                GlobalVariables.CurrentFreeKitsId = i + 1;
            }
        }
    }
}
