
using Homework.Common.Utils;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using static Homework.Common.Utils.AppUtlis;


namespace Homework.Common.Helpers
{
    internal class BrandControler
    {
        public static void Run()
        {
            AppUtlis.PrintSeparator();
            Console.WriteLine("1. Thêm");
            Console.WriteLine("2. Sửa");
            Console.WriteLine("2. Xóa");
            var option = GetValueFromKeyboard("Nhap lua chon: ");
            int optionConverted = Convert.ToInt32(option);
            BrandService brandService = new BrandService();
            var brands = new List<BrandModel>();
            switch (optionConverted)
            {
                case 1:


                    var id = 0;
                    do
                    {
                        id = ConvertValueTo(GetValueFromKeyboard("enter  id"));
                    }
                    while (brandService.CheckExistBrand(id) || id <= 0);
                    string name = "";
                    do
                    {
                        name = GetValueFromKeyboard("Enter Name");

                    } while ((brandService.CheckNameBrand(name) && !string.IsNullOrEmpty(name)) == false || string.IsNullOrEmpty(name) == false);

                    brandService.InsertBrand(new BrandModel(id, name));




                    break;
                case 2:
                    AppUtlis.PrintSeparator();
                    break;
                default:
                    AppUtlis.PrintSeparator();
                    break;
            }
        }
    }
}
