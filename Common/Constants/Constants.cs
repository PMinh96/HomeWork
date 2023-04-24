

using System.Security.Cryptography.X509Certificates;

namespace Homework.Common.Constants
{
    public static class OptionConstants
    {
        public static string AddProduct = "Thêm sản phẩm: ";
        public static List<string> Options = new List<string>()
                    {
                        AddProduct,
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
    }
    
}
