using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the whether there is lemon in the tea
        /// </summary>
        public bool Lemon { get; set; }

        //private backing variable
        private bool sweet;

        /// <summary>
        /// Gets and sets if the tea is sweetened or unsweetened
        /// </summary>
        public bool Sweet { 
                get { return sweet; }
                set{
                    sweet = value;
                    NotifyOfPropertyChange("Description");
                switch (Size)
                        {
                        case Size.Large:
                            if (sweet)
                            {
                            Calories = 64;
                            }
                            else
                            {
                            Calories = 32;
                            }
                            break;
                        case Size.Medium:
                            if (sweet)
                            {
                                Calories = 32;
                            }
                            else
                            {
                                Calories = 16;
                            }
                            break;
                        case Size.Small:
                            if (sweet)
                            {
                            Calories = 16;
                            }
                            else
                            {
                                Calories = 8;
                            }
                            break;
                         }
                
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
                List<string> list = new List<string>() { "Water", "Tea" };
                if (Lemon)
                {
                    list.Add("Lemon");
                }
                if (Sweet)
                {
                    list.Add("Cane Sugar");
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
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet)
                        {
                            Calories = 64;
                        }
                        else
                        {
                            Calories = 32;
                        }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet)
                        {
                            Calories = 32;
                        }
                        else
                        {
                            Calories = 16;
                        }
                        break;
                }
            }
            get { return size; }

        }

        /// <summary>
        /// Public constructor that initializes the default calories and price (size small)
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            if (Sweet)
            {
                this.Calories = 16;
            }
            else
            {
                this.Calories = 8;
            }
        }

        /// <summary>
        /// Method to add lemon to drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overriden ToString() for Tyrannotea class
        /// </summary>
        /// <returns>returns name of menu item as a string</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{Size} Sweet Tyrannotea";
            }
            return $"{Size} Tyrannotea";
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
