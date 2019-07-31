using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Bill : Fruit
    {
        protected Fruit fruit;
        public readonly int Quantity;

        public Bill(Fruit objFruit, int Qty) : base(objFruit.Description)
        {
            fruit = objFruit;
            Quantity = Qty;
        }
        public override double Cost { get => fruit.Cost * Quantity; }
    }
}
