namespace Homework.Models
{
    public class Mapping_WareHouse_ProductModel
    {
        #region Ctor

        public Mapping_WareHouse_ProductModel()
        {
        }

        public Mapping_WareHouse_ProductModel(int id, int idWarehouse, int productId, int quantity)
        {
            Id = id;
            IdProduct = productId;
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