using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week_3
{
    internal class ShoppingCart
    {
        private List<CartItem> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<CartItem>();
        }
        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public List<CartItem> GetList()
        {
            return cartItems;
        }

        public int GetBalance()
        {
            int balanceResult = 0;
            foreach (var item in cartItems)
            {
                balanceResult += item.Quantity * (item.Product.Price);
            }
            return balanceResult;
        }

        public void Remove(CartItem cartItem)
        {
            cartItems.Remove(cartItem);
        }
    }
}
