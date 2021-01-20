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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        // Private fields for combo and if a combo is being modified
        private CretaceousCombo combo;
        private bool isCombo = false;


        /// <summary>
        /// Initializes form
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for modifying combo drinks
        /// </summary>
        /// <param name="combo">The combo being modified</param>
        public DrinkSelection(CretaceousCombo combo)
        {
            this.combo = combo;
            Drink = combo.Drink;
            isCombo = true;
            InitializeComponent();
            ShowButtons();
        }

        /// <summary>
        /// Constructor that takes drink as parameter
        /// </summary>
        /// <param name="side">drink being set to</param>
        public DrinkSelection(Drink drink)
        {
            Drink = drink;
            InitializeComponent();
            ShowButtons();
        }

        /// <summary>
        /// Shows buttons based on what drink is being modified
        /// </summary>
        private void ShowButtons()
        {
            if (Drink is Sodasaurus)
            {
                Cream.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (Drink is Tyrannotea)
            {
                Cream.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Visible;
                Lemon.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (Drink is JurassicJava)
            {
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Visible;
                Decaf.Visibility = Visibility.Visible;
                Cream.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (Drink is Water)
            {
                Cream.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// The current drink
        /// </summary>
        private Drink Drink { get; set; }

        /// <summary>
        /// Dynamically displays different button options and adds drink
        /// </summary>
        /// <param name="sender">button that was pushed</param>
        /// <param name="args"></param>
        private void DrinkSelected(object sender, RoutedEventArgs args)
        {
            if (sender.Equals(SodaButton))
            {
                SelectDrink(new Sodasaurus());
                Cream.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (sender.Equals(TeaButton))
            {
                SelectDrink(new Tyrannotea());
                Cream.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Visible;
                Lemon.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (sender.Equals(JavaButton))
            {
                SelectDrink(new JurassicJava());
                Sweet.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Visible;
                Decaf.Visibility = Visibility.Visible;
                Cream.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }
            if (sender.Equals(WaterButton))
            {
                SelectDrink(new Water());
                Cream.Visibility = Visibility.Collapsed;
                Sweet.Visibility = Visibility.Collapsed;
                AddIcebtn.Visibility = Visibility.Collapsed;
                Flavor.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
                Ice.Visibility = Visibility.Visible;
            }

        }

        /// <summary>
        /// Selects flavor
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            if (isCombo)
                NavigationService.Navigate(new FlavorSelection(combo));
            else
                NavigationService.Navigate(new FlavorSelection(Drink as Sodasaurus));
        }

        /// <summary>
        /// Changes the size of the drink
        /// </summary>
        /// <param name="size">size being set</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                this.Drink.Size = size;
            if (isCombo) combo.Drink = Drink;
        }


        /// <summary>
        /// Sets size to small
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Sets size to medium
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Sets size to large
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSizeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Makes tyrannotea sweet
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeSweet(object sender, RoutedEventArgs args)
        {
            if(Drink is Tyrannotea tea)
            {
                tea.Sweet = true;
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// Adds Lemon to drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void AddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            else if(Drink is Water water)
            {
                water.AddLemon();
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// Holds ice from drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void RemoveIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if (Drink is Water water)
            {
                water.HoldIce();
            }
            else if (Drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// Adds ice to drink
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void AddIce(object sender, RoutedEventArgs args)
        {
            if(Drink is JurassicJava java)
            {
                java.AddIce();
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// Makes drink decaf
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void MakeDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.Decaf = true;
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// Leaves room for cream in Jurassic Java
        /// </summary>
        /// <param name="sender">flavor button being pushed</param>
        /// <param name="args"></param>
        private void LeaveRoomForCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.LeaveRoomForCream();
            }
            if (isCombo) combo.Drink = Drink;
        }

        /// <summary>
        /// The side that is added to the order
        /// </summary>
        /// <param name="side">Side being selected</param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                this.Drink = drink;
                if (!isCombo)
                {
                    order.Add(drink);   
                }
                else combo.Drink = drink;
            }
        }

        /// <summary>
        /// Returns to MenuCatagorySelection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Finish(object sender, RoutedEventArgs args)
        {
            if (isCombo) { NavigationService.Navigate(new CustomizeCombo(combo)); }
            else NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
