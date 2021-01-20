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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }

        public OrderControl()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Allows selected item to be modified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(Object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            if (OrderItems.SelectedItem is Entree entree)
            {
                if(entree is PterodactylWings){  }
                else { NavigationService?.Navigate(new CustomizeEntree(entree)); }  
            }
            if(OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeCombo(combo));
            }
        }

        public void OnDataContextChanged(Object sender, SelectionChangedEventArgs args)
        {
            MountItemListener();
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            //CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }

        private void MountItemListener()
        {
            if(DataContext is Order order)
            {
                //order.Items.CollectionChanged += OnCollectionChanged;
            }
        }

        private void OnItemRemoval(Object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
            }
            
        }
    }
}
