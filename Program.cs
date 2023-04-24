
using Homework.Common.Helpers;
using Homework.Data;
using System.Xml.Serialization;
using static Homework.Common.Utils.AppUtlis;
using static System.Net.Mime.MediaTypeNames;

namespace Homework
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int initProgram = 0;
            do
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Hello, Phan mem quan ly sieu cap PRO");
                Console.WriteLine("1: Chuong trinh quan ly San Pham");
                Console.WriteLine("2: Chuong trinh quan ly Nhan Hieu :");
                Console.WriteLine("3: Đóng chương trình :");
                initProgram = ConvertValueTo(GetValueFromKeyboard("nhập "));

                switch (initProgram)
                {
                    case 1:
                        ProductController.Run();
                        break;
                    case 2:
                        BrandControler.Run();
                        break;
                    case 3:
                        var option = GetValueFromKeyboard("Nhấn Y để đóng hoặc hoặc phím bất ký để nhập lại");

                        if (option.ToLower() == "y")
                        {
                            initProgram = 0;
                        }
                        else break;
                        break;
                    default:
                        Console.WriteLine("Vui long lua chon lai");
                        break;
                }
            } while (initProgram != 0);

        }


    }
}


