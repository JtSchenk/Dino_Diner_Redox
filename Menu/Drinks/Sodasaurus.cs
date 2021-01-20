using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasaurus menu item
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged
    {

        //Private Backing variable
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Flavor property
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return this.flavor; }
            set { flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the 
        /// Price, Description and Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets description of menu item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets special modifications to the order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Creates a private size field
        /// </summary>
        private Size size;
        public override Size Size
        {
            set
            {
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                }
            }
            get { return size; }
            
        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
        }

        /// <summary>
        /// Overriden ToString() for Sodasaurus class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";   
        }

        /// <summary>
        /// Holds ice
        /// </summary>
        public override void HoldIce()
        {
            NotifyOfPropertyChange("Special");
            Ice = false;
        }
    }
}
