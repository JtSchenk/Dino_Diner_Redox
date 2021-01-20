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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {

        /// <summary>
        /// The current drink
        /// </summary>
        public CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Initializes form
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The side that is added to the order
        /// </summary>
        /// <param name="side">Side being selected</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                Combo = new CretaceousCombo(entree);
                order.Add(Combo);
            }
        }

        /// <summary>
        /// Opens customize combo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            if (sender == VelociWrap) {
                SelectEntree(new VelociWrap());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == Brontowurst) {
                SelectEntree(new Brontowurst());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == PBJ) {
                SelectEntree(new PrehistoricPBJ());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == Nuggets) {
                SelectEntree(new DinoNuggets());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == Trex) {
                SelectEntree(new TRexKingBurger());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == Pterodactyl) {
                SelectEntree(new PterodactylWings());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }
            if (sender == Steakosaurus) {
                SelectEntree(new SteakosaurusBurger());
                NavigationService.Navigate(new CustomizeEntree(Combo));
            }

        }
    }
}
