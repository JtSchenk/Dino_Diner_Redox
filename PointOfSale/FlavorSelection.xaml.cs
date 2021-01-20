using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        //Field for sodasaurus, combo, and if it is a combo
        Sodasaurus soda;
        CretaceousCombo combo;
        bool isCombo = false;

        /// <summary>
        /// Initializes form
        /// </summary>
        public FlavorSelection(Sodasaurus sodasaurus)
        {
            soda = sodasaurus;
            InitializeComponent();
        }

        public FlavorSelection(CretaceousCombo combo)
        {
            this.combo = combo;
            isCombo = true;
            soda = (Sodasaurus)combo.Drink;
            InitializeComponent();
        }

        /// <summary>
        /// Changes flavor of drink to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeCherry(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cherry;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeChocolate(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Chocolate;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeLime(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Lime;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeVanilla(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Vanilla;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeOrange(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Orange;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to Cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeCola(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.Cola;
            Return();
        }

        /// <summary>
        /// Changes flavor of drink to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void MakeRootbeer(object sender, RoutedEventArgs args)
        {
            soda.Flavor = DinoDiner.Menu.SodasaurusFlavor.RootBeer;
            Return();
        }

        /// <summary>
        /// Returns to drink selection after changes have been made
        /// </summary>
        private void Return()
        {
            if (isCombo)
            {
                combo.Drink = soda;
                NavigationService.Navigate(new DrinkSelection(combo));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(soda));
            }
        }
    }
}
