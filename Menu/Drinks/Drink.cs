using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price.
        /// </summary>
        public virtual double Price { get; set; } //start

        /// <summary>
        /// Gets and sets whether there is ice or not
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Sets Ice to false
        /// </summary>
        public virtual void HoldIce()
        {
            NotifyOfPropertyChange("Special");
            Ice = false;
        }

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

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the 
        /// Price, Description and Special properties
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
