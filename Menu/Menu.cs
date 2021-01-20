using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List of available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nugs = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burg = new SteakosaurusBurger();
                TRexKingBurger kingburg = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                CretaceousCombo combo1 = new CretaceousCombo(wurst);
                CretaceousCombo combo2 = new CretaceousCombo(nugs);
                CretaceousCombo combo3 = new CretaceousCombo(pbj);
                CretaceousCombo combo4 = new CretaceousCombo(wings);
                CretaceousCombo combo5 = new CretaceousCombo(burg);
                CretaceousCombo combo6 = new CretaceousCombo(kingburg);
                CretaceousCombo combo7 = new CretaceousCombo(wrap);
                items.Add(java);
                items.Add(soda);
                items.Add(tea);
                items.Add(water);
                items.Add(wurst);
                items.Add(nugs);
                items.Add(pbj);
                items.Add(wings);
                items.Add(burg);
                items.Add(kingburg);
                items.Add(wrap);
                items.Add(fries);
                items.Add(mac);
                items.Add(sticks);
                items.Add(tots);
                items.Add(combo1);
                items.Add(combo2);
                items.Add(combo3);
                items.Add(combo4);
                items.Add(combo5);
                items.Add(combo6);
                items.Add(combo7);
                return items;
            }
        }

        /// <summary>
        /// List of available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nugs = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burg = new SteakosaurusBurger();
                TRexKingBurger kingburg = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                items.Add(wurst);
                items.Add(nugs);
                items.Add(pbj);
                items.Add(wings);
                items.Add(burg);
                items.Add(kingburg);
                items.Add(wrap);
                return items;
            }
        }

        /// <summary>
        /// List of available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                items.Add(fries);
                items.Add(mac);
                items.Add(sticks);
                items.Add(tots);
                return items;
            }
        }

        /// <summary>
        /// List of available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                items.Add(java);
                items.Add(soda);
                items.Add(tea);
                items.Add(water);
                return items;
            }
        }

        /// <summary>
        /// List of available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                foreach(Entree entree in AvailableEntrees)
                {
                    CretaceousCombo combo = new CretaceousCombo(entree);
                    items.Add(combo);
                }
                return items;
            }
        }

        /// <summary>
        /// List of possbile combos
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                List<string> result = new List<string>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        if (!result.Contains(ingredient))
                        {
                            result.Add(ingredient);
                        }
                    }
                }
                return result;
            }
        }


        /// <summary>
        /// Overriden ToString() for Menu class
        /// </summary>
        /// <returns>returns name of menu item</returns>
        public override string ToString()
        {
            string s = "";
            foreach (IMenuItem item in AvailableMenuItems)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }

        /// <summary>
        /// Gets list of order items that contain search term
        /// </summary>
        /// <param name="menuItems">List being searched</param>
        /// <param name="search">Term being searched</param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> menuItems, string search)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (item.ToString() != null && item.ToString().ToLower().Contains(search.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters menu by category
        /// </summary>
        /// <param name="categories">categories being filtered</param>
        /// <returns>List of menu items in categories</returns>
        public List<IMenuItem> FilterByCategory(List<string> categories)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            if (categories.Contains("Entree"))
            {    
                foreach(IMenuItem item in AvailableEntrees)
                {
                    results.Add(item);
                }            
            }
            if (categories.Contains("Drink"))
            {
                foreach (IMenuItem item in AvailableDrinks)
                {
                    results.Add(item);
                }
            }
            if (categories.Contains("Combo"))
            {
                foreach (IMenuItem item in AvailableCombos)
                {
                    results.Add(item);
                }
            }
            if (categories.Contains("Side"))
            {
                foreach (IMenuItem item in AvailableSides)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by minimum price
        /// </summary>
        /// <param name="menuItems">items being filtered</param>
        /// <param name="minPrice">minimum price</param>
        /// <returns>filtered list</returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuItems, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    results.Add(item);
                }

            }
            return results;
        }

        /// <summary>
        /// Filters by minimum price
        /// </summary>
        /// <param name="menuItems">Items being filtered</param>
        /// <param name="minPrice">Minimum price</param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuItems, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (item.Price <= minPrice)
                {
                    results.Add(item);
                }

            }
            return results;
        }

        /// <summary>
        /// Filters out excluded ingredients
        /// </summary>
        /// <param name="item">list being filtered</param>
        /// <param name="excluded">items being excluded</param>
        /// <returns>filtered list</returns>
        public List<IMenuItem> FilterByExcluded(List<IMenuItem> menuItem, List<string> excluded)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItem) {
                bool b = true;
                foreach(string s in item.Ingredients)
                {
                    if (excluded.Contains(s))
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    results.Add(item);
                }
             }
            return results;
        }
    }
}
