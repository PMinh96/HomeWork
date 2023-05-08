
using static Homework.Data.ProductsLists;
using Homework.Services.Interfaces;
using static Homework.Data.BrandData;
using Homework.Models;
using Homework.Dto;
using Homework.Data;
using System.Collections.Immutable;

namespace Homework.Services.Implements
{
    public class ProductService : IProductService
    {

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
        public List<ProductModel> SingleComperator1(string Operator, decimal price, decimal pricel)
        {
            return Operator switch
            {
                "lgt" => Products.Where(x => x.Price > price && x.Price <= pricel).ToList(),
            };
        }

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

        public void PrintInfo(List<ProductModel> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"id:{item.Id}, Name: {item.Name}, Price:{item.Price}");
            }
        }

        public List<ProductDto> SumProducts(decimal Operator, decimal price)
        {
            var result = from p in Products
                         where p.Price >= Operator && p.Price <= price
                         group p by p.Name into g
                         select new ProductDto()
                         {
                             Name = g.Key,
                             Count = g.Count()
                         };
            return result.ToList();
        }

        public bool InsertProduct(ProductModel product)
        {
            Products.Add(product);

            return Find(product.Id) == null;
        }

        public bool DeleteProduct(ProductModel product)
        {
            Products.RemoveAll(r => r.Id == product.Id);

            return Find(product.Id) == null;

        }

        public bool UpdateProduct(int id, string name, decimal price, int brandId)
        {
            var findProduct = Find(id);
            if (findProduct == null) return false;

            if (!string.IsNullOrEmpty(name))
            {
                findProduct.Name = name;
            }
            if (!string.IsNullOrEmpty(price.ToString()))
            {
                findProduct.Price = price;
            }
            if (!string.IsNullOrEmpty(brandId.ToString()))
            {
                findProduct.BrandId = brandId;
            }
            return true;
        }

        public ProductModel Find(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }

        public bool CheckExistProduct(int id)
        {
            return Products.Any(x => x.Id == id);
        }
        public bool CheckNameProduct(string name)
        {
            return ProductsLists.Products.Any(x => x.Name.ToLower() != name.ToLower());
        }

    }

}

