using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShoppingCarTested.Models;

namespace ShoppingCarTested
{
    public class Tools
    {
        public static List<Item> itemList = new List<Item>();
        public static ShoppingCartModel _shoppingCart = new ShoppingCartModel(DateTime.Now, itemList, 0.0);
        public static List<Item> AddItem(Item product)
        {
            //Resetting values 
           /*if(_shoppingCart.itemList.Count>0)
            {
                _shoppingCart.itemList.Clear();
                _shoppingCart.price = 0.0;
            }*/
            
            if (product != null) { 
            
                //Verify if the product list contains the same product recieved
                var equals = _shoppingCart.itemList.Where(d => d.name == product.name).FirstOrDefault();
                //if the product list contains the same product then add the quantity 
                if (equals != null)
                {
                    int index = _shoppingCart.itemList.IndexOf(equals);
                    _shoppingCart.itemList[index].quantity += product.quantity;
                }
                //if the product is not in the list then we added to list
                else if (equals == null)
                {
                _shoppingCart.itemList.Add(product);
                }
            }
            return _shoppingCart.itemList;
        }

        //Getting total of items only counting how many registers have the list
        public static int GetTotalItems()
        {
            return _shoppingCart.itemList.Count();
        }

        //Getting the total cart price to pay adding actual total and quantity * price
        public static double GetTotalCartPrice()
        {
            double _totalCartPrice = 0.0;
            foreach(var item in _shoppingCart.itemList)
            {
                _totalCartPrice = _totalCartPrice + (item.quantity * item.price);
            }
            return _totalCartPrice; 
        }

        //Getting the total Cart price to pay and substracting the payment 
        public static double Buy(double payment)
        {
            //Getting total cart price
            double _totalCartPrice = GetTotalCartPrice();
            //Verifying if the payment is bigger than the doubt
            if(payment<=_totalCartPrice)
            {
                _totalCartPrice = _totalCartPrice - payment;
            }
            else
            {
                throw new Exception("You shouldn't pay less than your doubt");
            }

            return _totalCartPrice;
        }
       
    }
}
