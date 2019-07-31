using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Apple : Fruit
    {
        public Apple() : base("Apple")
        {

        }
        /// <summary>
        /// Cost of single Apple
        /// </summary>
        public override double Cost { get => 0.60; }
    }
}
