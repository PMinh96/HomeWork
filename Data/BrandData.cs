using Homework.Models;

namespace Homework.Data
{
    public static class BrandData
    {
        public static List<BrandModel> Brands = new List<BrandModel>()
        {
            new() { Id = 1, Name = "SamSung" },
            new() { Id = 2, Name = "Iphone" },
            new() { Id = 3, Name = "Nokia" }
        };
    }
}