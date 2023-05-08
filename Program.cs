using Homework.Data;
using Homework.Dto;
using System.Diagnostics;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1
            WayOne();
            //2

            Way2();
        }

        public static void Way2()
        {
            #region [Vars]

            var warehouseProductMappings = Mapping_Warehouse_Product_Data.MappingWareHouseProducts;
            var warehouses = WareHousesData.Warehouses;
            var products = ProductsLists.Products;
            var brands = BrandData.Brands;

            #endregion [Vars]

            var joinQuery = (from wh in warehouses

                             join m in warehouseProductMappings on wh.Id equals m.IdWarehouse
                                 into ms
                             from m in ms.DefaultIfEmpty()

                             join p in products on m.IdProduct equals p.Id
                                 into ps
                             from p in ps.DefaultIfEmpty()

                             join b in brands on p.BrandId equals b.Id
                                 into bs
                             from b in bs.DefaultIfEmpty()

                             select new
                             {
                                 WhId = wh.Id,
                                 WhName = wh.Name,
                                 BrandId = b?.Id,
                                 ProductName = p?.Name,
                                 ProductPrice = p?.Price,
                                 Quantity = m?.Quantity
                             }
                    ).GroupBy(x => new
                    {
                        x.WhId,
                        x.WhName
                    }).Select(x => new MappingWareHouseProduct2Dto()
                    {
                        Id = x.Key.WhId,
                        Name = x.Key.WhName,
                        Brands = brands.Select(b => new BrandDto()
                        {
                            Name = b.Name,
                            Products = x.Where(p => p.BrandId == b.Id && p.WhId == x.Key.WhId).Select(p => new WarehouseProductMappingDto()
                            {
                                ProductName = p.ProductName,
                                Price = p.ProductPrice,
                                Quantity = p.Quantity,
                            }).ToList()
                        }).ToList()
                    });

            foreach (var wareHouse in joinQuery)
            {
                Console.WriteLine($"Warehouse: {wareHouse.Name}");
                foreach (var brand in wareHouse.Brands.Distinct())
                {
                    Console.WriteLine("     Brand");
                    Console.WriteLine($"    {brand.Name}");
                    foreach (var product in brand.Products)
                    {
                        Console.WriteLine($"        {product.ProductName} -  {product.Price} -  {product.Quantity}\n");
                    }
                }
            }
        }

        public static void WayOne()
        {
            // b1: hiển thị danh sách kho
            var warehouses = new List<MappingWareHouseProductDto>();

            foreach (var item in WareHousesData.Warehouses)
            {
                warehouses.Add(new MappingWareHouseProductDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Brands = BrandData.Brands
                });
            }

            var count = 0;

            var wareHouseProductMappings = Mapping_Warehouse_Product_Data.MappingWareHouseProducts;

            foreach (var warehouse in warehouses)
            {
                // 1: Tân Mai

                // lấy ra danh sách sản phẩm thuộc kho hiện tại
                var productIds = wareHouseProductMappings.Where(x => x.IdWarehouse == warehouse.Id).Select(x => x.IdProduct);
                var productsInWarehouse = ProductsLists.Products.Where(x => productIds.Contains(x.Id));

                count++;
                Console.WriteLine($"{count}. {warehouse.Name}");
                Console.WriteLine("_________________________________________________");

                foreach (var brand in warehouse.Brands)
                {
                    Console.WriteLine($"    {brand.Name}");

                    Console.WriteLine("     _________________________________________________");

                    var hasProduct = productsInWarehouse.Any(x => x.BrandId == brand.Id);
                    if (hasProduct)
                    {
                        var productsInBrand = productsInWarehouse.Where(x => x.BrandId == brand.Id);

                        Console.WriteLine("         Tên                Giá                Số lượng");
                        Console.WriteLine("         ______________________________________________");
                        foreach (var product in productsInBrand)
                        {
                            var quantity = wareHouseProductMappings.FirstOrDefault(x => x.IdProduct == product.Id)?.Quantity ?? 0;

                            Console.WriteLine($"         {product.Name}                {product.Price.ToString("###.###,###")}                {quantity}");

                            Console.WriteLine("         _________________________________________________");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"        Kho {warehouse.Name} không chứa bất kì sản phẩm nào thuộc nhãn hàng {brand.Name}");
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}