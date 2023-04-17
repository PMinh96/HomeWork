using Homework.Models;
using static Homework.Data.ProductsLists;
using Homework.Services.Interfaces;

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

        public void Find()
        {
            var find = Products.Where(x => x.Price == 5000).ToList();
            foreach (var product in find)
                Console.WriteLine($"{product.Name}, {product.Id}");
        }

        public void FindConditions()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            throw new NotImplementedException();
        }
    }
}
