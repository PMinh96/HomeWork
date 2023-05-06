using Homework.Models;

namespace Homework.Data
{
    public static class WareHousesData
    {
        public static List<WareHouseModel> Warehouses = new()
        {
                new WareHouseModel(1, "Tân mai"),
                new WareHouseModel(2, "Trương Định")
        };
    }
}