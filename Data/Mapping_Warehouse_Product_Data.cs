﻿using Homework.Models;

namespace Homework.Data
{
    public static class Mapping_Warehouse_Product_Data
    {
        public static List<Mapping_WareHouse_ProductModel> MappingWareHouseProducts = new  ()
        {
            new Mapping_WareHouse_ProductModel(1, 1, 1, 1000),

            new Mapping_WareHouse_ProductModel(2, 1, 2, 2000),

            new Mapping_WareHouse_ProductModel(3, 2, 1, 2000),

            new Mapping_WareHouse_ProductModel(4, 2, 2, 2000)
        };
    }
}