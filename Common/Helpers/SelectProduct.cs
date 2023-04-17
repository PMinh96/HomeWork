using static Homework.Common.Utils.AppUtlis;
namespace Homework.Common.Helpers
{
    public static class SelectProduct
    {
        public static void Products()
        {
            
            Console.WriteLine("===================================================================");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            var option = GetValueFromKeyboard("Nhap lua chon: "); 
            int optionConverted = Convert.ToInt32(option);
            switch (optionConverted)
            {
                case 1:
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("1");
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
