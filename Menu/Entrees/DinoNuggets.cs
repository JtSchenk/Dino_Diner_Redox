using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, INotifyPropertyChanged
    {
        // Number of nuggets being ordered (default 6)
        private int nuggetCount = 6;

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
                if (nuggetCount > 6) special.Add(nuggetCount-6 + " Extra Nuggets");
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
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }


        /// <summary>
        /// Constructs DinoNuggets menu item with calories and price
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// Adds a nugget to the order and updates calories, price and nuggetCount
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += .25;
            Calories += 59;
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overriden ToString() for DinoNuggets class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

    }
}
