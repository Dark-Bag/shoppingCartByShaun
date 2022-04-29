using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class ShoppingCartItem
    {
        public string itemName ;
        public double itemPrice;

        public ShoppingCartItem(string itemname)
        {
            itemName = itemname;
            itemPrice = 0.00;
        }

        public ShoppingCartItem(double itemprice)
        {
            itemName = "No Name";
            itemPrice = itemprice;
        }

        public ShoppingCartItem(string itemname, double itemprice)
        {
            itemName = itemname;
            itemPrice = itemprice;
        }

        public string ItemName
        {
            get { return itemName; }    
            set { itemName = value; }
        }
        public double ItemPrice
        {
            get { return itemPrice; }   
            set { itemPrice = value; }  
        }
    }
}
