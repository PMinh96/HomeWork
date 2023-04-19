using Homework.Models;
using Homework.Services.Implements;
using System.Linq.Expressions;
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

            ProductService productService = new ProductService();
            var products = new List<ProductModel>();
            switch (optionConverted)
            {
                case 1:
                    var value = GetValueFromKeyboard("nhập: ");
                    var valueArr = value.Split(",");
                    var value01 = decimal.Parse(valueArr[1]);
                    //var value02 = decimal.Parse(valueArr[2]);

                    Console.WriteLine("===================================================================");
                    products = productService.SingleComperator(valueArr[0], value01);
                    //products = productService.SingleComperator(valueArr[0], value01, value02);

                    productService.PrintInfo(products); 
                    break;
                case 4:
                    Console.WriteLine("===================================================================");
                    products = productService.OrderByProducts(true);
                    productService.PrintInfo(products);

                    break;
                    break;
                case 5:
                    Console.WriteLine("===================================================================");
                    products = productService.OrderByProducts(false);
                    productService.PrintInfo(products);
                    break;
                case 6:
                    Console.WriteLine("===================================================================");
                    productService.ProductDetail();
                    break;
                case 7:
                    var valueS = GetValueFromKeyboard("nhập:1 ");
                    var value1 = decimal.Parse(valueS);
                    var value2 = GetValueFromKeyboard(" nhập số 2: ");
                    var valueX = decimal.Parse(value2);


                    Console.WriteLine("===================================================================");
                    products = productService.SumProducts(value1, valueX);
                    break;

                default:
                    Console.WriteLine("===================================================================");
                    break;
            }
        }
    }
}
