
using Homework.Common.Helpers;
using Homework.Data;
using System.Linq.Expressions;
using static Homework.Common.Utils.AppUtlis;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Phan mem quan ly sieu cap PRO");

            Console.WriteLine("1: Chuong trinh quan ly San Pham");
            Console.Write("2: Chuong trinh quan ly Nhan Hieu :");

            //var option = GetValueFromKeyboard("Nhap lua chon: "); // A1
            //int optionConverted = Convert.ToInt32(option); // try catch, tryparse

            //switch (optionConverted)
            //{
            //    case 1:
            //        Console.WriteLine("");
            //        break;

            //    default:
            //        Console.WriteLine("Vui long lua chon lai");
            //        break;
            //}
            //var a = optionConverted switch
            
            var option = GetValueFromKeyboard("Nhap lua chon: "); // A1
            int optionConverted = Convert.ToInt32(option);

            switch (optionConverted)
            {
                case 1:
                    ProductController.Run();
                    break;
                case 2:
                    SelectBrand.Brands();
                    break;

                default:
                    Console.WriteLine("Vui long lua chon lai");
                    break;
            }

        }
    }
}


