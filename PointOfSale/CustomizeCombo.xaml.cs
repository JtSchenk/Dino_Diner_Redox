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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {

        /// <summary>
        /// The current drink
        /// </summary>
        public CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Initializes component
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            Combo = combo;
            InitializeComponent();
        }
        /// <summary>
        /// Sends user to side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void GetSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(Combo));
        }
        /// <summary>
        /// Sends user to drink selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void GetDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(Combo));
        }

        /// <summary>
        /// Changes the size of the combo
        /// </summary>
        private void SelectSize(object sender, RoutedEventArgs args)
        {
            if (sender == Small)
            {
                Combo.Size = DinoDiner.Menu.Size.Small; ;
            }
            if (sender == Medium)
            {
                Combo.Size = DinoDiner.Menu.Size.Medium;
            }
            if (sender==Large)
            {
                Combo.Size = DinoDiner.Menu.Size.Large;
            }
            
        }

        /// <summary>
        /// Returns to menucategoryselection page after finishing the combo customizations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Finish(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
