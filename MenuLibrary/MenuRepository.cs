using MenuList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRepository
    
{
  public class MenuRepo
    {
        private List<Menu>_menuItems = new List<Menu>();
        
        // create
        public void AddMenuItemToList(Menu menuItem)
        {
            _menuItems.Add(menuItem);
        }

        // read
        public List<Menu> GetMenuItemList()
        {
            return _menuItems;
        }
        
        // update
        public bool UpdateMeal(string originalMeal, Menu newMeal)
        {
            // Find Meal 
            Menu oldMeal = GetMenuItemByName(originalMeal);

            // Update Meal 
            if (oldMeal != null)
            {
                oldMeal.MealName = newMeal.MealName;
                oldMeal.MealDescription = newMeal.MealDescription;
                oldMeal.MealNumber = newMeal.MealNumber;
                oldMeal.MealPrice = newMeal.MealPrice;
                oldMeal.TypeOfIngredient = newMeal.TypeOfIngredient;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // delete
        public bool RemoveItemFromList(string mealName)
        {
            Menu menuItem = GetMenuItemByName(mealName);
            if(menuItem == null)
            {
                return false;
            }
            int initialCount = _menuItems.Count;
            _menuItems.Remove(menuItem);
            if(initialCount > _menuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // helper 
        public Menu GetMenuItemByName(string mealName)
        {
            foreach(Menu menuItem in _menuItems)
            {
                if(menuItem.MealName == mealName)
                {
                    return menuItem;
                }
            }

            return null;
        }
    }
}
