using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class DiscountB2G1 : Bill
    {
        /// <summary>
        /// Discount class for offer Buy 2 get 1 free , inherited from Bill to extend 
        /// functionality of billing with discount on any fruit.
        /// </summary>
        public DiscountB2G1(Fruit objFruit, int Qty) : base(objFruit, Qty)
        {

        }

        public override string Description => fruit.Description + " :*Offer B2G1";

        public override double Cost => fruit.Cost * ((double)(Math.Ceiling((decimal)(Quantity / 3m) * 2)));
    }
}
