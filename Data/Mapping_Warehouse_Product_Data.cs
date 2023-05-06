using Homework.Models;

namespace Homework.Data
{
    public static class Mapping_Warehouse_Product_Data
    {
        public static List<Mapping_WareHouse_Product> MappingWareHouseProducts = new()
        {
            new Mapping_WareHouse_Product(1, 1, 1, 1000),
            new Mapping_WareHouse_Product(2, 1, 2, 2000),

            new Mapping_WareHouse_Product(3, 2, 1, 2000),
            new Mapping_WareHouse_Product(4, 2, 2, 2000)
        };
    }
}