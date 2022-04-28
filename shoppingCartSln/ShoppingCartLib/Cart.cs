using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Cart: ShoppingCart
    {
        private List<ShoppingCartItem> Cartitems;
        double sumT;
        double sumTWithVAT;

        public Cart()
        {
            Cartitems = new List<ShoppingCartItem>();    
        }

        public void AddToTheCart(string itemname, double itemprice)
        {
            ShoppingCartItem item = new ShoppingCartItem(itemname, itemprice);
            this.Cartitems.Add(item);
           
        }

        public IEnumerable<string> GetCartItemNames()
        {
            foreach (var item in this.Cartitems)
            {
                yield return item.itemName;
            }
        }

        public double subTotal(double itemprice)
        {
            
            ShoppingCartItem total = new ShoppingCartItem(itemprice);

            sumT += total.itemPrice;
            return sumT;
        }

        public double subTotalWithVAT(double itemprice)
        {

            ShoppingCartItem totalVAT = new ShoppingCartItem(itemprice);

            sumTWithVAT = totalVAT.itemPrice * 1.15;
            return sumTWithVAT;
        }


    }
}
