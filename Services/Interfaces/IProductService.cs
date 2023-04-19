
using System.Collections.Generic;
using Homework.Models;

namespace Homework.Services.Interfaces
{
    interface IProductService
    {
        void PrintInfo(List<ProductModel> products );
        
        // đếm hàng theo hãng 
        List<ProductModel> SumProducts(decimal Operator, decimal price);

        List<ProductModel> SingleComperator(string Operator, decimal price);
        //List<ProductModel> SingleComperator(string Operator, decimal price, decimal pricel);

        void FindProviso();

        // định nghĩa list sắp xếp
        List<ProductModel> OrderByProducts(bool asc);

        



        void ProductDetail();

        void SelectBrand();


    }
}
