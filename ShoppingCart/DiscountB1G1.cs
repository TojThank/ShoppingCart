using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    /// <summary>
    /// Discount class for offer buy 1 get 1, inherited from Bill to extend 
    /// functionality of billing with discount on any fruit.
    /// </summary>
    public class DiscountB1G1 : Bill
    {
        public DiscountB1G1(Fruit objFruit, int Qty) : base(objFruit, Qty)
        {

        }

        public override string Description => fruit.Description + " :*Offer B1G1";

        public override double Cost => fruit.Cost * (double)Math.Ceiling((decimal)(Quantity / 2m));
    }
}
