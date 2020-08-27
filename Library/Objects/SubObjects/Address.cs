namespace Gesk.Library.Objects.SubObjects
{
    public class Address
    {
        public int Id { get; set; }
        public string Row { get; set; }
        public string Side { get; set; }
        public string Column { get; set; }
        public string Rack { get; set; }

        public Address(){}

        public Address(int id, string row, string side, string column, string rack)
        {
            Id = id;
            Row = row;
            Side = side;
            Column = column;
            Rack = rack;
        }

        public static int GetAddressId(Address address)
        {
            if (address == null) return -1;

            int index = GlobalVariables.Addresses.FindIndex(x => x.Row == address.Row && x.Side == address.Side && x.Column == address.Column && x.Rack == address.Rack);

            if (index < 0) return -1;

            return GlobalVariables.Addresses[index].Id;
        }

        public static int GetAddressId(string address)
        {
            if (address == "N/D") return -1;

            int index = GlobalVariables.Addresses.FindIndex(x => x.ToString() == address);

            if (index < 0) return -1;

            return GlobalVariables.Addresses[index].Id;
        }

        public static string GetAddressString(int id)
        {
            if (id == -1) return "N/D";

            int index = GlobalVariables.Addresses.FindIndex(x => x.Id == id);

            if (index < 0) return "N/D";

            return GlobalVariables.Addresses[index].Row + GlobalVariables.Addresses[index].Side + GlobalVariables.Addresses[index].Column + GlobalVariables.Addresses[index].Rack;
        }

        public static string GetAddressStringNonStorage(int id)
        {
            if (id == -1) return "N/D";

            int index = GlobalVariables.Addresses.FindIndex(x => x.Id == id);

            if (index < 0) return "N/D";

            return GlobalVariables.Addresses[index].Row + GlobalVariables.Addresses[index].Side + GlobalVariables.Addresses[index].Column + GlobalVariables.Addresses[index].Rack;
        }

        public override string ToString()
        {
            return this.Row + this.Side + this.Column + this.Rack;
        }
    }
}
