using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Brontowurst menu item
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, INotifyPropertyChanged
    {
        //Backing variables for ingredients
        private bool bun = true;
        private bool onion = true;
        private bool braut = true;
        private bool peppers = true;

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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!onion) special.Add("Hold Onion");
                if (!peppers) special.Add("Hold Peppers");
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
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (braut) ingredients.Add("Brautwurst");
                if (onion) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for Brontowurst with price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes peppers from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Removes onion from ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overriden ToString() for brontowurst class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}