using System;

namespace ShoppingCart
{
    /// <summary>
    /// Abstract class for fruit
    /// </summary>
    public abstract class Fruit
    {
        private string description;
        public Fruit(string strDescription)
        {
            description = strDescription;
        }
        /// <summary>
        /// Description of Fruit 
        /// </summary>
        public virtual string Description { get { return description; } }

        /// <summary>
        /// Cost of fruit
        /// </summary>
        public abstract double Cost { get; }
    }
}
