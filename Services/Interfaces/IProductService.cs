﻿
using System.Collections.Generic;
using Homework.Dto;
using Homework.Models;

namespace Homework.Services.Interfaces
{
    interface IProductService
    {
        void PrintInfo(List<ProductModel> products);

        // đếm hàng theo hãng 
        List<Productdto> SumProducts(decimal Operator, decimal price);

        List<ProductModel> SingleComperator(string Operator, decimal price);
        //List<ProductModel> SingleComperator(string Operator, decimal price, decimal pricel);

        void FindProviso();

        // định nghĩa list sắp xếp
        List<ProductModel> OrderByProducts(bool asc);


        bool InsertProduct(ProductModel product);
        bool DeleteProduct(ProductModel product);
        bool UpdateProduct(ProductModel product);

        ProductModel Find(int id);
        bool CheckExistProduct(int id);

    }
}
