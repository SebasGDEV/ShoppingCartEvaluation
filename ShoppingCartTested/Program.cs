
//THIS WAS USED AS AN EXAMPLE PRINTING IN CONSOLE

/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShoppingCarTested.Models;

namespace ShoppingCarTested
{
    class Program
    {
        public static void Main(string[] args)
        {

            static string RandomString(int size)
            {
                StringBuilder builder = new StringBuilder();
                Random random = new Random();
                char ch;
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }

                return builder.ToString();
            }
            
            Random rnd = new Random();
            int totalItemsToGenerate = 3;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
      
            for (int i = 0; i < totalItemsToGenerate; i++)
            {
                var randomName = RandomString(10);
                var randomQuantity = rnd.Next(1, 20);
                var randomPrice = rnd.NextDouble();
                randomPrice *= 100;
                var item = new Item(randomName, randomQuantity, randomPrice);
                Tools.AddItem(item);
            }
            stopWatch.Stop();

            var list = Tools.AddItem(new Models.Item("Item 3", 10, 15.5)); 

            var totalItems = Tools.GetTotalItems();
            var totalPriceCart = Tools.GetTotalCartPrice();
            Console.WriteLine("Total Price Cart: " + totalPriceCart);
            Console.WriteLine(totalItems);
            for(int i =0; i<totalItems; i++)
            {
                Console.WriteLine("Name: {0} Quantity: {1} Price: {2}", list[i].name, list[i].quantity, list[i].price);

            }
            Console.WriteLine("En segundos {0} ", stopWatch.ElapsedMilliseconds * 0.001);
            Console.WriteLine(Tools.GetTotalItems());
        }
    }
}
*/