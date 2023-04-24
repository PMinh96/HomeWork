using System.Numerics;
using System.Xml.Linq;

namespace Homework.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        // Khóa ngoại
        public int BrandId { get; set; }
        public ProductModel() { }

        // Overloading contructor
        public ProductModel(int id, string name, decimal price, int brandId)
        {
            id = Id;
            name = Name;
            price = Price;
            brandId = BrandId;
        }
    }
}

