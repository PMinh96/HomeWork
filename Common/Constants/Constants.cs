

using System.Security.Cryptography.X509Certificates;

namespace Homework.Common.Constants
{
    public static class OptionConstants
    {
        //public static string AddProduct = "Thêm sản phẩm: ";
        public static List<string> Options = new List<string>()
        {   "Tìm sản phẩm theo giá(Lt, Price: bằng giá nhập vào, lt, Price: nhỏ hơn giá nhập vào)",
            "Tổng sản phẩm ASC",
            "Tổng sản phẩm DESC",
            "Số lượng sản phẩm theo giá",
            "Price Ascending",
            "Thêm sản phẩm",
            "Xóa sản phẩm",
            "tìm sản phẩm trong khoảng giá"
        };

        public static List<String> OptionsBrands = new List<string>()
        {
            "Thêm",
            "Sửa",
            "Xóa",
        };
    }

}
