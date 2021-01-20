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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes form
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            DataContext = order;

            OrderList.NavigationService = OrderInterface.NavigationService;
        }

        public void GoBack(object sender, RoutedEventArgs args)
        {
            if (OrderList.NavigationService.CanGoBack)
            {
                OrderList.NavigationService.GoBack();
            }
            else
            {
                OrderList.NavigationService.Navigate(new MenuCategorySelection());
            }
        }


        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        public void OnDataContextChanged(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }
    }
}
