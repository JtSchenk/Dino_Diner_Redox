using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// VelociWrap menu item
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, INotifyPropertyChanged
    {
        //private bools for ingredients
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!dressing) special.Add("Hold Caesar Dressing");
                if (!cheese) special.Add("Hold Parmesan Cheese");
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
                List<string> ingredients = new List<string>() { };
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs VelociWrap with specified price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds lettuce from the list of ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds dressing from list of ingredients
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Holds cheese from list of ingredients
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overriden ToString() for VelociWrap class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
