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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Initializes form
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Navigates to combo selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Navigates to side seleciton form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// Navigates to entree selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Navigates to drink selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
