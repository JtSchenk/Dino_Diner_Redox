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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        //Private fields to the combo and if it is a combo
        private CretaceousCombo combo;
        private bool isCombo = false;

        /// <summary>
        /// Initializes form
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that takes side as parameter
        /// </summary>
        /// <param name="side">side being set to</param>
        public SideSelection(Side side)
        {
            Side = side;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that takes combo as parameter
        /// </summary>
        /// <param name="combo">combo being set</param>
        public SideSelection(CretaceousCombo combo)
        {
            Side = combo.Side;
            this.combo = combo;
            isCombo = true;
            InitializeComponent();
        }

        /// <summary>
        /// The current side
        /// </summary>
        public Side Side {get; set;}

        /// <summary>
        /// The side that is added to the order
        /// </summary>
        /// <param name="side">Side being selected</param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (!isCombo) 
                    order.Add(side);
                this.Side = side;
            }
            if (isCombo) combo.Side = Side;
        }

        /// <summary>
        /// Changes the size of the side
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
                if (isCombo) combo.Side = Side;
            }
            if(isCombo)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Adds new side item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Adds new side item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Adds new side item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Adds new side item to current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// Changes selected side to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Changes selected side to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Changes selected side to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
    }
}
