namespace Homework.Models
{
    public class Mapping_WareHouse_ProductModel
    {
        #region Ctor

        public Mapping_WareHouse_ProductModel()
        {
        }

        public Mapping_WareHouse_ProductModel(int id, int idWarehouse, int brand, int quantity)
        {
            Id = id;
            IdBrand = brand;
            IdWarehouse = idWarehouse;
            Quantity = quantity;
          
        }

        #endregion Ctor

        public int Id { get; set; }

        public int IdWarehouse { get; set; }

        public int IdBrand { get; set; }
         

        public int Quantity { get; set; }

        
    }
}