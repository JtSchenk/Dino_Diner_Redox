using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// IMenuItem interface for menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price property
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories property
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// List of ingredients property
        /// </summary>
        List<string> Ingredients{get;}


    }
}
