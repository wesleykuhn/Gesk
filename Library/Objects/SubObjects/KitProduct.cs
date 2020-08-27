namespace Gesk.Library.Objects.SubObjects
{
    public class KitProduct
    {
        public int Quantity { get; set; }
        public int Id_Product { get; set; }

        public KitProduct(){}

        public KitProduct(int quantity, int id_Product)
        {
            Quantity = quantity;
            Id_Product = id_Product;
        }
    }
}
