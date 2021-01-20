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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        //Private fields to store entree, combo and if it is a combo
        private Entree entree;
        private CretaceousCombo combo;
        private bool isCombo = false;

        /// <summary>
        /// Constructor that gets the entree being modified
        /// </summary>
        /// <param name="entree">Entree being modified</param>
        public CustomizeEntree(Entree entree)
        {
            this.entree = entree;
            InitializeComponent();
            SetButtons();
        }

        /// <summary>
        /// Constructor that gets the entree being modified from a combo
        /// </summary>
        /// <param name="entree">Combo being modified</param>
        public CustomizeEntree(CretaceousCombo combo)
        {
            this.entree = combo.Entree;
            this.combo = combo;
            isCombo = true;
            InitializeComponent();
            SetButtons();
        }

        /// <summary>
        /// Displays certain buttons depending on the entree being modified
        /// </summary>
        private void SetButtons()
        {
                InitializeComponent();
                if (entree is Brontowurst)
                {
                    Onion.Visibility = Visibility.Visible;
                    Peppers.Visibility = Visibility.Visible;
                    Bun.Visibility = Visibility.Visible;
                }
                if (entree is PrehistoricPBJ)
                {
                    PeanutButter.Visibility = Visibility.Visible;
                    Jelly.Visibility = Visibility.Visible;
                }
                if (entree is DinoNuggets)
                {
                    Nugget.Visibility = Visibility.Visible;
                }
                if (entree is SteakosaurusBurger)
                {
                    Bun.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                    Ketchup.Visibility = Visibility.Visible;
                    Mustard.Visibility = Visibility.Visible;
                }
                if (entree is TRexKingBurger)
                {
                    Onion.Visibility = Visibility.Visible;
                    Bun.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                    Ketchup.Visibility = Visibility.Visible;
                    Mustard.Visibility = Visibility.Visible;
                    Mayo.Visibility = Visibility.Visible;
                    Lettuce.Visibility = Visibility.Visible;
                    Tomato.Visibility = Visibility.Visible;
                }
                if (entree is VelociWrap)
                {
                    Lettuce.Visibility = Visibility.Visible;
                    Dressing.Visibility = Visibility.Visible;
                    Cheese.Visibility = Visibility.Visible;
                }
        }

        /// <summary>
        /// Holds Peanut Butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Adds nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            if (entree is DinoNuggets nugs)
            {
                nugs.AddNugget();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldOnion();
            }
            if (entree is TRexKingBurger king)
            {
                king.HoldOnion();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldPeppers();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldBun();
            }
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldBun();
            }
            if (entree is TRexKingBurger king)
            {
                king.HoldBun();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Pickles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldPickle();
            }
            if (entree is TRexKingBurger king)
            {
                king.HoldPickle();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKethup(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldKetchup();
            }
            if (entree is TRexKingBurger king)
            {
                king.HoldKetchup();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldMustard();
            }
            if (entree is TRexKingBurger king)
            {
                king.HoldMustard();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds Lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldLettuce();
            }
            if (entree is VelociWrap wrap)
            {
                wrap.HoldLettuce();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldTomato();
            }
        }

        /// <summary>
        /// Holds mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldMayo();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Holds dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap wrap)
            {
                wrap.HoldDressing();
            }
        }


        /// <summary>
        /// Holds dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap wrap)
            {
                wrap.HoldCheese();
            }
            if (isCombo) combo.Entree = entree;
        }

        /// <summary>
        /// Goes back to menu selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnFinish(object sender, RoutedEventArgs args)
        {
            if (isCombo) { NavigationService.Navigate(new CustomizeCombo(combo)); }
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
