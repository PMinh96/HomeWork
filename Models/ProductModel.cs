namespace Homework.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        // Khóa ngoại
        public int BrandId { get; set; }
    }
}
