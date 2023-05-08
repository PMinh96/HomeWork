using Homework.Models;

namespace Homework.Dto
{
    public class MappingWareHouseProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BrandModel> Brands { get; set; }
    }

    public class MappingWareHouseProduct2Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BrandDto> Brands { get; set; }
    }
}