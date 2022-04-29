using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Cart
    {
       
        double sumT;
        double sumTWithVAT;


        private List<ShoppingCartItem> Cartitems = new List<ShoppingCartItem>();    
        

        public void AddToTheCart(ShoppingCartItem itemmm)
        {
          
            this.Cartitems.Add(itemmm);
           
        }

        public List<ShoppingCartItem> GetCartItems()
        {
            return this.Cartitems;  
            
        }

        public double subTotal()
        {

            foreach (ShoppingCartItem item in Cartitems)
            {
                sumT += item.itemPrice;
            }
            return Math.Round(sumT, 2);
        }

        public double subTotalWithVAT()
        {

            foreach (ShoppingCartItem item in Cartitems)
            {
                sumTWithVAT = sumT * 1.15;
            }
            return Math.Round(sumTWithVAT, 2);
        }

        public void Clear()
        {
            this.Cartitems.Clear();
            this.sumT= 0;
            this.sumTWithVAT= 0;

        }


    }
}
