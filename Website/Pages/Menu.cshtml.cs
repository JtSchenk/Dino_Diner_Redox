using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The menu being used by the form to display items
        /// </summary>
        public DinoDiner.Menu.Menu Menu { get; } = new DinoDiner.Menu.Menu();

        public List<IMenuItem> MenuList;

        [BindProperty]
        public string Search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();



        public void OnGet()
        {
            MenuList = Menu.AvailableMenuItems;
        }

        public void OnPost(string search, List<string> menuCategory, float? minimumPrice, float? maximumPrice, List<string> excludeIngredient)
        {
            MenuList = Menu.AvailableMenuItems;

            if (menuCategory.Count != 0)
            {
                MenuList = Menu.FilterByCategory(menuCategory);
            }
            if (search != null)
            {
                MenuList = Menu.Search(MenuList, search);
            }  
            if (minimumPrice != null)
            {
                MenuList = Menu.FilterByMinPrice(MenuList, (float)minimumPrice);
            }
            if (maximumPrice != null)
            {
                MenuList = Menu.FilterByMaxPrice(MenuList, (float)maximumPrice);
            }
            if (excludeIngredient.Count != 0)
            {
                MenuList = Menu.FilterByExcluded(MenuList, excludeIngredient);
            }

        }
    }
}