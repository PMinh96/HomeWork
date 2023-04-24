using Homework.Data;
using static Homework.Data.BrandList;
using Homework.Models;
using Homework.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace Homework.Services.Implements
{
    internal class BrandService : IBrandService
    {
        public bool InsertBrand(BrandModel brand)
        {
            Brands.Add(brand);
            return Find(brand.Id) != null;
        }

        

        public bool CheckExistBrand(int id)
        {
            return BrandList.Brands.Any(x => x.Id == id);
        }

        public BrandModel Find(int id)
        {
            return Brands.FirstOrDefault(x => x.Id == id);
        }

        public bool CheckNameBrand(string name)
        {
            return BrandList.Brands.Any(x=>x.Name.ToLower() == name.ToLower());
        }
    }
}
