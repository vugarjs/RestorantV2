using Restoran.Models;
using Restoran.Services;


namespace Restoran
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Pizza", 2);
            FoodService service = new FoodService();
            Console.WriteLine(service.WhenWillPrepared(pizza1));
        }
    }
}
