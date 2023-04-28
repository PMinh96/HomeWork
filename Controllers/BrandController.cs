
using Homework.Common.Utils;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using System.Security.Cryptography;
using static Homework.Common.Utils.AppUtlis;



namespace Homework.Common.Helpers
{
    internal class BrandControler
    {
        public static void Run()
        {
            AppUtlis.PrintSeparator();
            AppUtlis.PrintOptionBrand();
            var option = GetValueFromKeyboard("Nhap lua chon: ");
            int optionConverted = Convert.ToInt32(option);
            BrandService brandService = new BrandService();
            var brands = new List<BrandModel>();
            switch (optionConverted)
            {
                case 1:
                    var id = 0;
                    string name = "";
                    id = ConvertValueTo(GetValueFromKeyboard("Enter Brand ID"));
                    AppUtlis.RepeatConditionBrand(id);

                    name = GetValueFromKeyboard("Enter Brand ID");
                    AppUtlis.RepeatConditionBrand(name);

                    brandService.InsertBrand(new BrandModel(id, name));
                    break;
                case 2:
                    var idDelete = ConvertValueTo(GetValueFromKeyboard("Enter Brand ID Delete "));

                    var found = brandService.Find(idDelete);
                    if (found != null)
                    {
                        brandService.DeleteBrand(found);
                    }
                    else
                    {
                        Console.WriteLine("sai");
                    }
                    break;
                case 3:
                    var idUpdate = ConvertValueTo(GetValueFromKeyboard("ID Product Update"));

                    var found1 = brands.Find(idUpdate);
                    if (found1 != null)
                    {
                        productService.DeleteProduct(found1);
                    }
                    else
                    {
                        Console.WriteLine("sai");
                    }
                    break;
                    break;
                default:
                    AppUtlis.PrintSeparator();
                    break;
            }
        }
    }
}
