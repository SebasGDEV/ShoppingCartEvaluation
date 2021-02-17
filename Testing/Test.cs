using ShoppingCarTested;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static ShoppingCarTested.Models;

namespace Testing
{
    
    public class Test
    {
        //GENERATING RANDOM STRINGS TO ITEMS
        private string RandomString(int size)
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

        [Fact]
        public void Can_Add_An_Item_To_List()
        {
            //IF IS NOT NULL THEN WE ADDED AN ITEM TO THE LIST ONLY WITH NAME COMPARISON
            var item1 = new Item("Item 2", 10, 15.5);
            var resultList = Tools.AddItem(item1);
            var equals = resultList.Where(d => d.name == item1.name).FirstOrDefault();
            int index = resultList.IndexOf(equals);
            Assert.Equal(resultList[index], equals);
        }
        [Fact]
        public void Get_Total_Items()
        {
            //Generating 100 random registers
            Random rnd = new Random();
            int totalItemsToGenerate = 100;
            var list = new List<Item>();
            for (int i = 0; i < totalItemsToGenerate; i++)
            {
                var randomName = RandomString(10);
                var randomQuantity = rnd.Next(1, 20);
                var randomPrice = rnd.NextDouble();
                randomPrice *= 100;
                var item = new Item(randomName, randomQuantity, randomPrice);
                list = Tools.AddItem(item);
            }
            var totalItemsExpected = list.Count();
            var totalItems = Tools.GetTotalItems();
            Assert.Equal(totalItemsExpected, totalItems);
        }

        [Fact]
        public void Get_Total_Cart_Price()
        {
            //Generating 100 random registers
            Random rnd = new Random();
            double totalPriceCartExpected = 0.0;
            int totalItemsToGenerate = 100;
            for (int i = 0; i < totalItemsToGenerate; i++)
            {
                var randomName = RandomString(10);
                var randomQuantity = rnd.Next(1, 20);
                var randomPrice = rnd.NextDouble();
                randomPrice *= 100;
                var item = new Item(randomName, randomQuantity, randomPrice);
                 Tools.AddItem(item);
                //Im getting the total price in the procceso
                totalPriceCartExpected = totalPriceCartExpected + (item.quantity * item.price);
            }
            //Here I'm getting the total price with an external function
            var totalPriceCart = Tools.GetTotalCartPrice();
            Assert.Equal(totalPriceCartExpected, totalPriceCart);
        }

        [Fact]
        public void Buy_Paying_To_Substract_Total_Price()
        {
            //Generating 100 random registers
            Random rnd = new Random();
            int totalItemsToGenerate = 100;
            for (int i = 0; i < totalItemsToGenerate; i++)
            {
                var randomName = RandomString(10);
                var randomQuantity = rnd.Next(1, 20);
                var randomPrice = rnd.NextDouble();
                randomPrice *= 100;
                var item = new Item(randomName, randomQuantity, randomPrice);
                Tools.AddItem(item);
            }
            //Getting the total price of the cart 
            var totalPriceCart = Tools.GetTotalCartPrice();
            //Paying half of the mount
            var finalResult = Tools.Buy(totalPriceCart/2);
            Assert.Equal(totalPriceCart/2, finalResult);
        }



    }
}
