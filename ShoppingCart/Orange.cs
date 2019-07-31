using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Orange : Fruit
    {
        public Orange() : base("Orange")
        {

        }
        /// <summary>
        /// Cost of single Orange
        /// </summary>
        public override double Cost { get => 0.25; }
    }
}
