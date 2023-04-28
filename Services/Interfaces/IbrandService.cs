

using Homework.Models;

namespace Homework.Services.Interfaces
{
    interface IBrandService
    {
        bool InsertBrand(BrandModel brand); 

        bool DeleteBrand(BrandModel brand);

        bool UpdateBrand(BrandModel brand);

        BrandModel Find(int id);

        bool CheckExistBrand(int id);

    }
}
