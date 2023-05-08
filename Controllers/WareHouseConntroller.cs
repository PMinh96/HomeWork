using Homework.Services.Implements;








namespace Homework.Controllers
{
    public class WareHouseConntroller
    {
        public static void run()
        {
            WareHouseServices wareHouseServices = new WareHouseServices();

            var SumProductWareHouse = wareHouseServices.SumProductWareHouses();
                foreach ( var item in SumProductWareHouse )
            {
                Console.WriteLine($"Name: {item.Name} Quantity: {item.Quantity} warehouse:{item.WareHouse}");
            }
        }
    }
}
