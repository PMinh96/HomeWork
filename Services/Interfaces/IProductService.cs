
using System.Collections.Generic;
using Homework.Dto;
using Homework.Models;

namespace Homework.Services.Interfaces
{
    interface IProductService
    {
        void PrintInfo(List<ProductModel> products);

        // đếm hàng theo hãng 
        List<ProductDto> SumProducts(decimal Operator, decimal price);

        List<ProductModel> SingleComperator(string Operator, decimal price);
   
        void FindProviso();

        // định nghĩa list sắp xếp
        List<ProductModel> OrderByProducts(bool asc);


        bool InsertProduct(ProductModel product);

        bool DeleteProduct(ProductModel product);

        /// <param name="id"></param>
        /// <returns></returns>
        bool UpdateProduct(int id, string name, decimal price, int brandId);

        ProductModel Find(int id);
        bool CheckExistProduct(int id);

    }
}
