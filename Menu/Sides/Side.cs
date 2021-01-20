using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract base class for all the sides on the menu
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Property to get description
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Property to get the modifications to the order (eg "Hold Mayo")
        /// </summary>
        public virtual string[] Special { get; }

        public virtual event PropertyChangedEventHandler PropertyChanged;
    }
}
