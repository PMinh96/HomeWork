using Homework.Data;
using static Homework.Data.BrandList;
using Homework.Models;
using Homework.Services.Interfaces;


namespace Homework.Services.Implements
{
    internal class BrandService : IBrandService
    {
        public bool InsertBrand(BrandModel brand)
        {
            Brands.Add(brand);
            return Find(brand.Id) == null;
        }

        public bool DeleteBrand(BrandModel brand)
        {
            Brands.RemoveAll(r => r.Id == brand.Id);

            return Find(brand.Id) == null;
        }

        public bool UpdateBrand(BrandModel brand)
        {
            var found = Find(brand.Id);
            if (found == null)
            {
                return false;
            }
            else
            {
                found.Name = brand.Name;
                if (brand.Name == found.Name)
                {
                    return true;
                }
                else { return false; }
            }
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
            return BrandList.Brands.Any(x=>x.Name.ToLower() != name.ToLower());
        }
    }
}
