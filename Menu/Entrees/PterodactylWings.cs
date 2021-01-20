using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{

    /// <summary>
    /// Class for Pterodactly wings menu item
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem, INotifyPropertyChanged
    {

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
                return new List<string>() { "Chicken", "Wing Sauce"};
            }

        }

        /// <summary>
        /// Constructor for PterodactylWings that sets price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Overriden ToString() for PterodactylWings class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
