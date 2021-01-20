using System;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        //Backing variable
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Items that have been added to the order
        /// </summary>
        public IOrderItem[] Items {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Total price of all items in order
        /// </summary>
        public double SubtotalCost {
            get {
                double subtotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal > 0)
                    return subtotal;
                else 
                    return 0;
            }
        }

        /// <summary>
        /// The sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .1;

        /// <summary>
        /// The additional costs associated with sales tax
        /// </summary>
        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }

        /// <summary>
        /// The total cost of the order including the price of the items and sales tax
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        /// <summary>
        /// Creates new order instance
        /// </summary>
        public Order()
        {

        }

        //Notifies of changes to the order
        protected void NotifyofAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyofAllPropertiesChanged();
        }

        /// <summary>
        /// Adds item to order
        /// </summary>
        /// <param name="item">item being added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyofAllPropertiesChanged();
        }

        /// <summary>
        /// Removes item from order
        /// </summary>
        /// <param name="item">item being removed</param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyofAllPropertiesChanged();
            }
            return removed;
        }
    }
}
