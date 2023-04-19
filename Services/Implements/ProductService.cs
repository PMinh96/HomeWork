
using static Homework.Data.ProductsLists;
using Homework.Services.Interfaces;
using static Homework.Data.BrandList;
using Homework.Models;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Services.Implements
{
    public class ProductService : IProductService
    {

        public void Arrangement()
        {
            throw new NotImplementedException();
        }
        public List<ProductModel> OrderByProducts(bool _asc)
        {
            return _asc ? Products.OrderBy(x => x.Price).ToList() : Products.OrderByDescending(x => x.Price).ToList();
        }

        public List<ProductModel> SingleComperator(string Operator, decimal price)
        {
            return Operator switch
            {

                "gt" => Products.Where(x => x.Price == price).ToList(),
                "lt" => Products.Where(x => x.Price < price).ToList(),
            };

        }
        //public List<ProductModel> SingleComperator(string Operator, decimal price, decimal pricel)
        //{
        //    return Operator switch
        //    {
        //        "lgt" => Products.Where(x => x.Price > price && x.Price <= pricel).ToList(),
        //    };
        //}

        public void FindProviso()
        {
            var result = from b in Brands
                         join p in Products on b.Id equals p.BrandId
                         group p by b.Name into g
                         select new
                         {
                             Name = g.Key,
                             Count = g.Count()
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void ProductDetail()
        {
            //var result = from p in Products
            //             join b in Brands on p.BrandId equals b.Id
            //             group p by p.Name into g
            //             select new
            //             {
            //                 Name = g.Key,
            //                 brandName = b.Name,
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }

        public void SelectBrand()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
           

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ToString());
            //}

        }

        public void PrintInfo(List<ProductModel> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"id:{item.Id}, Name: {item.Name}, Price:{item.Price}");
            }
        }

        public List<ProductModel> SumProducts(decimal Operator, decimal price)
        {
            var result = from p in Products
                         where p.Price >= Operator && p.Price <= price
                         group p by p.Name into g
                         select new
                         {
                             Name = g.Key,
                             Count = g.Count()
                         };
            return  ProductModel(result);
        }
    }
}
