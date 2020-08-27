using Gesk.Library.Entities;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System.Collections.Generic;

namespace Gesk.Library
{
    public static class GlobalVariables
    {
        public static List<User> Users = new List<User>() { new User(0, "admin", "admin") };
        public static List<Product> Products = new List<Product>();
        public static List<Address> Addresses = new List<Address>();
        public static List<Kit> Kits = new List<Kit>();

        public static int CurrentFreeAddressId = 0;
        public static int CurrentFreeProductsId = 0;
        public static int CurrentFreeKitsId = 0;
    }
}
