namespace Homework.Models
{
    public class Mapping_WareHouse_Product
    {
        #region Ctor

        public Mapping_WareHouse_Product()
        {
        }

        public Mapping_WareHouse_Product(int id, int idWarehouse, int idProduct, int quantity)
        {
            Id = id;
            IdProduct = idProduct;
            IdWarehouse = idWarehouse;
            Quantity = quantity;
        }

        #endregion Ctor

        public int Id { get; set; }
        public int IdWarehouse { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
    }
}