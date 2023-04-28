
using Homework.Common.Utils;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using static Homework.Common.Utils.AppUtlis;
namespace Homework.Common.Helpers;

public static class ProductController
{
    public static void Run()
    {
        AppUtlis.PrintSeparator();
        AppUtlis.PrintOption();

        ProductService productService = new ProductService();
        var products = new List<ProductModel>();

        BrandService brandService = new BrandService();
        var brands = new List<BrandModel>();

        var option = GetValueFromKeyboard("Nhap lua chon: ");
        int optionConverted = Convert.ToInt32(option);
        switch (optionConverted)
        {
            case 1:
                var value = GetValueFromKeyboard("nhập: ");
                var valueArr = value.Split(",");
                var value01 = decimal.Parse(valueArr[1]);

                AppUtlis.PrintSeparator();
                products = productService.SingleComperator(valueArr[0], value01);
                productService.PrintInfo(products);
                break;

            case 2:
                AppUtlis.PrintSeparator();
                products = productService.OrderByProducts(true);
                productService.PrintInfo(products);
                break;

            case 3:
                AppUtlis.PrintSeparator();
                products = productService.OrderByProducts(false);
                productService.PrintInfo(products);
                break;

            case 4:
                AppUtlis.PrintSeparator();
                var valueS = GetValueFromKeyboard("nhập1:  ");
                var value1 = decimal.Parse(valueS);
                var value2 = GetValueFromKeyboard(" nhập số 2: ");
                var valueX = decimal.Parse(value2);


                AppUtlis.PrintSeparator();
                var Sumproducts = productService.SumProducts(value1, valueX);
                foreach (var item in Sumproducts)
                {
                    Console.WriteLine($"Name: {item.Name} Count: {item.Count}");
                }
                break;

            case 5:
                AppUtlis.PrintSeparator();
                string _name = "";
                var id = 0;

                _name = GetValueFromKeyboard("Enter Product Name");
                AppUtlis.RepeatConditionProduct(_name);
                id = ConvertValueTo(GetValueFromKeyboard("Enter Product ID"));
                AppUtlis.RepeatConditionProduct(id);

                var price = ConvertValueTo(GetValueFromKeyboard("Enter Product Price"));

                //chọn thêm mới hoặc chọn cũ
                var choice = ConvertValueTo(GetValueFromKeyboard("Select key: 1. dùng có sẵn  2. thêm mới brand")); ;
                var brand = 0;
                string nameBrand = "";
                var _id = 0;
                switch (choice)
                {
                    case 1:
                        brand = ConvertValueTo(GetValueFromKeyboard("Brand 1.SamSung 2.Iphone 3.Nokia"));
                        productService.InsertProduct(new ProductModel(id, _name, price, brand));
                        break;

                    case 2:
                        _id = ConvertValueTo(GetValueFromKeyboard("Enter Brand ID"));
                        AppUtlis.RepeatConditionBrand(id);

                        nameBrand = GetValueFromKeyboard("Enter Brand ID");
                        AppUtlis.RepeatConditionBrand(nameBrand);

                        brandService.InsertBrand(new BrandModel(_id, nameBrand));
                        break;
                }
                break;

            case 6:
                AppUtlis.PrintSeparator();
                var idDelete = ConvertValueTo(GetValueFromKeyboard("Enter Product ID Delete "));

                var found = productService.Find(idDelete);
                if (found != null)
                {
                    productService.DeleteProduct(found);
                }
                else
                {
                    Console.WriteLine("sai");
                }
                break;

            case 7:
                var valueLg = GetValueFromKeyboard("Price lgt,Fromt,to ");
                var valueArr1 = valueLg.Split(",");
                var valueLg01 = decimal.Parse(valueArr1[1]);
                var valueLg02 = decimal.Parse(valueArr1[2]);

                AppUtlis.PrintSeparator();
                products = productService.SingleComperator1(valueArr1[0], valueLg01, valueLg02);
                productService.PrintInfo(products);
                break;

            case 8:
                var idUpdate = ConvertValueTo(GetValueFromKeyboard("ID Product Update"));
                
                if (idUpdate != null)
                {
                    var getnameUpdate = GetValueFromKeyboard("Updata Name");
                    
                    var getPriceUpdate = ConvertValueTodecimal(GetValueFromKeyboard("Update Price"));

                    var getBrandIDUpdate = ConvertValueTo(GetValueFromKeyboard("Updata BrandID"));

                    productService.UpdateProduct(idUpdate, getnameUpdate, getPriceUpdate, getBrandIDUpdate);
                }
                else
                {
                    Console.WriteLine("sai");
                }
                break;

            default:
                AppUtlis.PrintSeparator();
                break;
        }
    }
}

