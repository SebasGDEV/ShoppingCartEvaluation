using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarTested
{
    public class Models
    {
        public class ShoppingCartModel
        {
            public DateTime date = DateTime.Now;
            public List<Item> itemList = new List<Item>();
            public double price = 0.0;
            


            public ShoppingCartModel(DateTime date, List<Item> itemList, double price)
            {
                this.date = date;
                this.itemList = itemList;
                this.price = price;
            }

        }
        public class Item
        {
            public string name;
            public int quantity;
            public double price;
            public bool getList;

            public Item(bool getList)
            {
                this.getList = getList;
            }
            public Item(string name, int quantity, double price)
            {
                this.name = name ?? throw new ArgumentNullException(nameof(name));
                this.quantity = quantity;
                this.price = price;
            }
        }
    }
}
