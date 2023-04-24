
using Homework.Common.Utils;
using Homework.Models;
using Homework.Services.Implements;
using Homework.Services.Interfaces;
using System.Xml.Serialization;
using static Homework.Common.Utils.AppUtlis;
namespace Homework.Common.Helpers;

public static class ProductController
{
    public static void Run()
    {

        AppUtlis.PrintSeparator();
        AppUtlis.PrintOption();
       
        var option = GetValueFromKeyboard("Nhap lua chon: ");


        int optionConverted = Convert.ToInt32(option);

        ProductService productService = new ProductService();
        var products = new List<ProductModel>();
        BrandService brandService = new BrandService();
        var brands = new List<BrandModel>();

        switch (optionConverted)
        {
            case 1:
                var value = GetValueFromKeyboard("nhập: ");
                var valueArr = value.Split(",");
                var value01 = decimal.Parse(valueArr[1]);
                //var value02 = decimal.Parse(valueArr[2]);

                AppUtlis.PrintSeparator();
                products = productService.SingleComperator(valueArr[0], value01);
                //products = productService.SingleComperator(valueArr[0], value01, value02);

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
                string name = null;
                var id = 0;
                do
                {
                     name = GetValueFromKeyboard("enter name product");
                }
                while (productService.CheckNameProduct(name) ||  name == null);
                
                do
                {
                    id = ConvertValueTo(GetValueFromKeyboard("enter  id"));
                }
                while (productService.CheckExistProduct(id) || id <= 0);

                var price = ConvertValueTo(GetValueFromKeyboard("enter price"));



                //chọn thêm mới hoặc chọn cũ
                var choice = ConvertValueTo(GetValueFromKeyboard("Select key: 1. dùng có sẵn  2. thêm mới brand")); ;
                var brand = 0;
                switch (choice)
                {
                    case 1:
                        brand = ConvertValueTo(GetValueFromKeyboard("Brand 1.SamSung 2.Iphone 3.Nokia"));
                        productService.InsertProduct(new ProductModel(id, name, price, brand));
                        break;
                    case 2:
                        var _id = 0;
                        do
                        {
                            id = ConvertValueTo(GetValueFromKeyboard("enter  id brand"));
                        }
                        while (brandService.CheckExistBrand(id) || id <= 0);
                        string _name = "";
                        do
                        {
                            name = GetValueFromKeyboard("Enter Name brand");

                        } while ((brandService.CheckNameBrand(_name) && !string.IsNullOrEmpty(_name)) == false || string.IsNullOrEmpty(_name) == false);

                        brandService.InsertBrand(new BrandModel(id, name));
                        productService.InsertProduct(new ProductModel(id, name, price, _id));
                        break;
                }

                

                break;
            case 6:
                AppUtlis.PrintSeparator();
                var idDelete = ConvertValueTo(GetValueFromKeyboard("enter  id delete: "));

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

            default:
                AppUtlis.PrintSeparator();
                break;
        }
    }
}

