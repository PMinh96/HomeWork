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
            Console.WriteLine("2.sản phẩm còn lại theo hãng");
            Console.WriteLine("3.sản phẩm từ 5-10000");
            Console.WriteLine("4.sắp xếp theo giá tăng dần");
            Console.WriteLine("5.sắp xếp theo giá giảm dần");
            Console.WriteLine("6.sản phẩm");
            Console.WriteLine("tổng tiền");
            var option = GetValueFromKeyboard("Nhap lua chon: ");
            int optionConverted = Convert.ToInt32(option);
            ProductService Product = new ProductService();
            switch (optionConverted)
            {
                case 1:
                    Console.WriteLine("===================================================================");
                    
                    Product.Find();
                    
                    break;
                case 2:
                    Console.WriteLine("===================================================================");
                    Product.FindProviso();
                    break;
                case 3:
                    Product.Sum();
                    break;

                case 4:
                    Console.WriteLine("===================================================================");
                    Product.Asc();
                    break;
                case 5:
                    Console.WriteLine("===================================================================");
                    Product.Desc();
                    break;
                case 6:
                    Console.WriteLine("===================================================================");
                    Product.ProductDetail();
                    break;
                case 7:
                    Console.WriteLine("===================================================================");
                    Product.Desc();
                    break;

                default:
                    Console.WriteLine("===================================================================");
                    break;
            }
        }
    }
}
