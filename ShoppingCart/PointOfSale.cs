using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    /// <summary>
    /// Class point of sale used to fetch the shopping cart and create bill
    /// </summary>
    public class PointOfSale
    {
        private Dictionary<string, int> shoppingCart;
        private List<Bill> bills;

        /// <summary>
        /// Fetch the bills from shoping cart
        /// </summary>
        public List<Bill> Bills {
            get
            {
                if (bills == null)
                {
                    bills = new List<Bill>();
                    foreach (var item in shoppingCart)
                    {
                        switch (item.Key)
                        {
                            case "Apple":
                                bills.Add(new DiscountB1G1(new Apple(), item.Value));
                                break;
                            case "Orange":
                                bills.Add(new DiscountB2G1(new Orange(), item.Value));
                                break;
                        }
                    }
                }
                return bills;
            }
        }

        /// <summary>
        /// Create the PointOfSale object and intailizes Shoppingcart from the string array
        /// </summary>
        /// <param name="cartItems"> string array of items </param>
        public PointOfSale(string[] cartItems)
        {
            shoppingCart = new Dictionary<string, int>();
            foreach (string fruit in cartItems)
            {
                if (shoppingCart.ContainsKey(fruit))
                    shoppingCart[fruit] += 1;
                else
                    shoppingCart.Add(fruit, 1);
            }
        }
    }
}
