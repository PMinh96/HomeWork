namespace Homework.Models
{
    public class BrandModel
    {
        // Khóa chính
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandModel() { }

        public BrandModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    
}