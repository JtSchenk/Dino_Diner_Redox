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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Initializes entree selection form
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the Entree
        /// </summary>
        /// <param name="side">Entree being set to</param>
        public EntreeSelection(Entree entree)
        {
            Entree = entree;
            InitializeComponent();
        }

        /// <summary>
        /// The current entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// The entree that is added to the order
        /// </summary>
        /// <param name="side">entree being selected</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
            if(entree is PterodactylWings)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                NavigationService.Navigate(new CustomizeEntree(entree));
            }  
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
        }

        /// <summary>
        /// Adds new entree item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }
    }
}
