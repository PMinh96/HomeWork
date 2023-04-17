
using static Homework.Data.ProductsLists;
using Homework.Services.Interfaces;
using static Homework.Data.BrandList;
using Homework.Models;

namespace Homework.Services.Implements
{
    public class ProductService : IProductService
    {
        //public List<ProductModel> GetProductsPrice5k()
        //{
        //    // truyền thống for - foreach

        //    // linq
        //    // lamda
        //    return Products.Where(x => x.Price == 5000).ToList();
        //}
        //public int SumProduct() => Products.Count();
        public void Arrangement()
        {
            throw new NotImplementedException();
        }

        public void Asc()
        {
            var result = from Products in Products
                         orderby Products.Price ascending
                         select Products;
            foreach (var item in result)
            {
                Console.WriteLine($"id: {item.Id},name: {item.Name},Price: {item.Price}");
            }
        }

        public void Desc()
        {
            var result = from Products in Products
                         orderby Products.Price descending
                         select Products;
            foreach (var item in result)
            {
                Console.WriteLine($"id: {item.Id},name: {item.Name},Price: {item.Price}");
            }
        }

        public void Find()
        {
            var find = Products.Where(x => x.Price == 5000).ToList();
            foreach (var product in find)
                Console.WriteLine($"{product.Name}, {product.Id}");
        }

        public void FindConditions()
        {
            var find = Products.Where(x => x.Price >= 10000).ToList();
            foreach (var item in find)
                Console.WriteLine($"id: {item.Id},name: {item.Name},Price: {item.Price}");
        }

        public void FindGreaterThan()
        {
            var result = from item in Products
                         where item.Price > 5000 && item.Price <= 20000
                         select item;
            foreach (var item in result)
            {
                Console.WriteLine($"id: {item.Id},name: {item.Name},Price: {item.Price}");
            }
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

        public void ProductDetail()
        {
            var result = from p in Products
                         join b in Brands on p.BrandId equals b.Id
                         group p by p.Name into g
                         select new
                         {
                             Name = g.Key,
                             brandName = b.Name,
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void SelectBrand()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            var result = from p in Products
                         where p.Price >= 5000 && p.Price <= 10000
                         group p by p.Name into g
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
    }
}
