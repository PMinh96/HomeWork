using Homework.Common.Helpers;
using static Homework.Common.Utils.AppUtils;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int initProgram;
            do
            {
                DisplayAppOptions();

                initProgram = ConvertValueTo(GetValueFromKeyboard());

                switch (initProgram)
                {
                    case 1:
                        ProductController.Run();
                        break;

                    case 2:
                        BrandController.Run();
                        break;

                    case 3:
                        var option = GetValueFromKeyboard("Nhấn Y để đóng hoặc hoặc phím bất ký để nhập lại");

                        if (option.ToLower() == "y")
                        {
                            initProgram = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("Vui long lua chon lai");
                        break;
                }
            } while (initProgram != 0);
        }

        private static void DisplayAppOptions()
        {
            Console.WriteLine("Hello, Phan mem quan ly sieu cap PRO");
            Console.WriteLine("1: Chuong trinh quan ly San Pham");
            Console.WriteLine("2: Chuong trinh quan ly Nhan Hieu :");
            Console.WriteLine("3: Đóng chương trình :");
        }
    }
}