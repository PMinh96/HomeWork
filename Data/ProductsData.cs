
using Homework.Models;

namespace Homework.Data
{
    public static class ProductsLists
    {
        public static List<ProductModel> Products = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id = 1,
                    Name = "Fold 3",
                    Price = 10000,
                    BrandId = 1
                },
                new ProductModel()
                {
                    Id = 2,
                    Name = "IPhone x",
                    Price = 20000,
                    BrandId = 2
                },
                new ProductModel()
                {
                    Id = 3,
                    Name = "1200",
                    Price = 5000,
                    BrandId = 3
                },
                new ProductModel()
                {
                    Id = 4,
                    Name = "Iphone 7",
                    Price = 8000,
                    BrandId = 2
                },
                new ProductModel()
                {
                    Id = 5,
                    Name = "SamSung A3",
                    Price = 75000,
                    BrandId = 1
                },
                new ProductModel()
                {
                    Id = 6,
                    Name = "6300",
                    Price = 200,
                    BrandId = 3
                }
            };
    }
}
