using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets whether there is lemon or not
        /// </summary>
        public bool Lemon{ get; set; }


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
        /// Gets the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the special modifications to the order if any
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Overrides the base class list of ingredients with the ones specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> list = new List<string>() { "Water" };
                if (Lemon)
                {
                    list.Add("Lemon");
                }
                return list;
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
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
        }

        /// <summary>
        /// Method to add lemon to drink
        /// </summary>
        public void AddLemon()
        {
            NotifyOfPropertyChange("Special");
            Lemon = true;
        }


        /// <summary>
        /// Overriden ToString() for Water class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            return $"{Size} Water";
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
