

using Homework.Common.Constants;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using System.Security.Cryptography;


namespace Homework.Common.Utils
{

    public static class AppUtlis
    {
        public static string GetValueFromKeyboard(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? string.Empty;
        }

        public static int ConvertValueTo(string value)
        {
            return int.TryParse(value, out var output) ? output : 0;
        }
        public static decimal ConvertValueTodecimal(string value)
        {
            return decimal.TryParse(value, out var output) ? output : 0;
        }

        public static void PrintSeparator()
        {
            Console.WriteLine("===================================================================");
        }
        public static void PrintOption()
        {
            var count = 1;

            foreach (string option in OptionConstants.Options)
            {
                Console.WriteLine($"{count}, {option}");
                count++;
            }
        }

        public static void PrintOptionBrand()
        {
            var count = 1;

            foreach (string option in OptionConstants.OptionsBrands)
            {
                Console.WriteLine($"{count}, {option}");
                count++;
            }
        }

        public static void RepeatConditionProduct(string name)
        {
            ProductService productService = new ProductService();


            while ((productService.CheckNameProduct(name) && string.IsNullOrEmpty(name)) == true || string.IsNullOrEmpty(name) == true)
            {
                name = GetValueFromKeyboard("re-enter name");
            }
        }

        public static void RepeatConditionProduct(int id)
        {
            ProductService productService = new ProductService();


            while (productService.CheckExistProduct(id) || id <= 0)
            {
                id = ConvertValueTo(GetValueFromKeyboard("re-enter id"));
            }
        }

        public static void RepeatConditionBrand(int id)
        {
            BrandService brandService = new BrandService();

            while (brandService.CheckExistBrand(id) || id <= 0)
            {
                id = ConvertValueTo(GetValueFromKeyboard("re-enter id"));
            }
        }

        public static void RepeatConditionBrand(string name)
        {
            BrandService brandService = new BrandService();
            var brands = new List<BrandModel>();
            while ((brandService.CheckNameBrand(name) && string.IsNullOrEmpty(name)) == true || string.IsNullOrEmpty(name) == true)
            {
                name = GetValueFromKeyboard("Enter Name brand");
            }
        }

    }
}
