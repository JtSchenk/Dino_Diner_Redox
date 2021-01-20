using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for jurassic java
    /// </summary>
    public class JurassicJava : Drink , IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        //Backing variable
        private bool decaf;
        /// <summary>
        /// Gets and sets whether the drink is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                NotifyOfPropertyChange("Description");
                decaf= value;
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
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
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
               return new List<string>() { "Water", "Coffee" };
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                }
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            HoldIce();
        }

        /// <summary>
        /// Leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overriden ToString() for JurassicJava class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Jurassic Java";
            }
            return $"{Size} Jurassic Java";
        }


    }
}
