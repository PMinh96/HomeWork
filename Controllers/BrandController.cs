using Homework.Common.Utils;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using static Homework.Common.Utils.AppUtils;

namespace Homework.Common.Helpers
{
    internal class BrandController
    {

        public static void Run()
        {
            AppUtils.PrintSeparator();
            AppUtils.PrintOptionBrand();

            var option = GetValueFromKeyboard();
            var optionConverted = AppUtils.ConvertValueTo(option);

            PrepareRun(optionConverted);
        }

        public static void PrepareRun(int optionConverted)
        {
            var _brandService = new BrandService();
            switch (optionConverted)
            {
                case 1:
                    var id = 0;
                    string name = "";
                    id = ConvertValueTo(GetValueFromKeyboard("Enter Brand ID"));
                    AppUtils.RepeatConditionBrand(id);

                    name = GetValueFromKeyboard("Enter Brand ID");
                    AppUtils.RepeatConditionBrand(name);

                    _brandService.InsertBrand(new BrandModel(id, name));
                    break;

                case 2:
                    var idDelete = ConvertValueTo(GetValueFromKeyboard("Enter Brand ID Delete "));

                    var found = _brandService.Find(idDelete);
                    if (found != null)
                    {
                        _brandService.DeleteBrand(found);
                    }
                    else
                    {
                        Console.WriteLine("sai");
                    }
                    break;

                case 3:
                    var idUpdate = ConvertValueTo(GetValueFromKeyboard("ID Product Update"));

                    var foundUpdated = _brandService.Find(idUpdate);
                    if (foundUpdated != null)
                    {
                        _brandService.UpdateBrand(foundUpdated);
                    }
                    else
                    {
                        Console.WriteLine("sai");
                    }
                    break;

                default:
                    AppUtils.PrintSeparator();
                    break;
            }
        }
    }
}