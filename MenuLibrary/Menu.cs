using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuList



{
    public enum IngredientList
    {
        Beef =1,
        Chicken,
        Fish,
        Steak,
        
    }
    // poco
    public class Menu

    {
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public int MealNumber { get; set; }
        public IngredientList TypeOfIngredient { get; set; }
        public double MealPrice { get; set; }

        public Menu() { }
        public Menu(string mealName, string mealDescription, int mealNumber, IngredientList typeOfIngredient, double mealPrice)
        {
            MealName = mealName;
            MealDescription = mealDescription;
            MealNumber = mealNumber;
            TypeOfIngredient = typeOfIngredient;
            MealPrice = mealPrice;

            
        }

    }
    
}   
