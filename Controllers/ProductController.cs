using Homework.Services.Implements;
using static Homework.Common.Utils.AppUtlis;
namespace Homework.Common.Helpers
{
    public static class ProductController
    {
        public static void Run()
        {

            Console.WriteLine("===================================================================");
            Console.WriteLine("1.tìm sản phẩm có giá bằng 5000");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            var option = GetValueFromKeyboard("Nhap lua chon: ");
            int optionConverted = Convert.ToInt32(option);
            switch (optionConverted)
            {
                case 1:
                    Console.WriteLine("===================================================================");
                    ProductService Find5k = new ProductService();
                    Find5k.Find();
                    
                    break;
                case 2:
                    Console.WriteLine("===================================================================");
                    break;
                default:
                    Console.WriteLine("===================================================================");
                    break;
            }
        }
    }
}
