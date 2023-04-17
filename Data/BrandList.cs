using Homework.Models;

namespace Homework.Data
{
    public static class BrandList
    {
        public static List<BrandModel> Brands = new List<BrandModel>()
            {
            new BrandModel() { Id = 1, Name = "SamSung"},
            new BrandModel() { Id = 2, Name = "Iphone"},
            new BrandModel() { Id = 3, Name = "Nokia"}
            };
    }
}