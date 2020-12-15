using MenuList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class MenuUI
    {
        private Menu _menuItems = new Menu();

        // Method that starts/runs application
        public void Run()
        {
            SeedContentList();
            MainMenu();
        }

        // Menu
        private void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display options to user 
                Console.WriteLine("Please select a menu option:\n" +
                    "1.Create New Menu Item\n" +
                    "2.View All Menu Items\n" +
                    "3.Update Existing Meal\n" +
                    "4.Delete Existing Meal\n" +
                    "5.Exit");
                // Get user input 
                string input = Console.ReadLine();

                // Evaluate user input and do whats needed 
                switch (input)
                {
                    // Create new menu item 
                    case "1":
                        CreateNewMeal();
                        break;
                    // View all Menu Item 
                    case "2.":
                        DisplayAllMeals();
                        break;
                    // Update Exisitng Meals
                    case "3":
                        UpdateMeals();
                        break;
                    // Delete Meals
                    case "4.":
                        DeleteMeals();
                        break;
                    //Exit 
                    case "5":
                        Console.WriteLine("GoodBye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number:");
                        break;
                }

                Console.WriteLine("Please press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }

      
        // create new 
        private void CreateNewMeal()
        {
            Menu newMeal = new Menu();

            // MealName 
            Console.WriteLine("Enter the Name for this Meal");
            newMeal.MealName = Console.ReadLine();

            // MealDescription
            Console.WriteLine("Enter the Description for Meal");
            newMeal.MealDescription = Console.ReadLine();

            // Meal Number 
            Console.WriteLine("Enter the Number for the Meal");
            string numberAsString = Console.ReadLine();
            newMeal.MealNumber = int.Parse(numberAsString);

            // Meal PRice 
            Console.WriteLine("Enter the Price for the Meal");
            string priceAsString = Console.ReadLine();
            newMeal.MealPrice = double.Parse(priceAsString);

            // Type of Ingredients
            Console.WriteLine("Please enter the number for which ingredients the meal contains:\n" +
                "1.Beef\n" +
                "2.Chicken\n" +
                "3.Fish\n" +
                "4.Steak");

            string ingredientsAsString = Console.ReadLine();
            int ingredientsAsInt = int.Parse(ingredientsAsString);
            newMeal.TypeOfIngredient = (IngredientList)ingredientsAsInt;

           
        }

            // view exisitng 
        private void DisplayAllMeals()
        {
            Console.Clear();
            List<Menu> listOfMeals = _menuItems.ViewAllMeals();
            foreach(Menu meals in listOfMeals)
            {
                Console.WriteLine($"mealName: { meals.MealName}\n" +
                    $"Desc: {meals.MealDescription}");
                    
            }    

        }
            // update existing
        private void UpdateMeals()
        {
            // Display Meals 
            DisplayAllMeals();
            // ask for meal to update 
            Console.WriteLine("enter meal you would like to update");
            // get that meal 
            string oldMeal = Console.ReadLine();
            //build new meal 
            Menu newMeal = new Menu();

            // MealName 
            Console.WriteLine("Enter the Name for this Meal");
            newMeal.MealName = Console.ReadLine();

            // MealDescription
            Console.WriteLine("Enter the Description for Meal");
            newMeal.MealDescription = Console.ReadLine();

            // Meal Number 
            Console.WriteLine("Enter the Number for the Meal");
            string numberAsString = Console.ReadLine();
            newMeal.MealNumber = int.Parse(numberAsString);

            // Meal PRice 
            Console.WriteLine("Enter the Price for the Meal");
            string priceAsString = Console.ReadLine();
            newMeal.MealPrice = double.Parse(priceAsString);

            // Type of Ingredients
            Console.WriteLine("Please enter the number for which ingredients the meal contains:\n" +
                "1.Beef\n" +
                "2.Chicken\n" +
                "3.Fish\n" +
                "4.Steak");

            string ingredientsAsString = Console.ReadLine();
            int ingredientsAsInt = int.Parse(ingredientsAsString);
            newMeal.TypeOfIngredient = (IngredientList)ingredientsAsInt;

            bool wasUpdated = _menuItems.UpdateMeal(oldMeal, newMeal);
            if (wasUpdated)
            {
                Console.WriteLine("Meal was successfully update");
            }
            else
            {
                Console.WriteLine("Meal could not be updated");
               
            }
        }
        // delete existing
        private void DeleteMeals()
        {
            DisplayAllMeals();
            //Get meal to delete
            Console.WriteLine("Enter the meal number which you want to remove:");
            string input = Console.ReadLine();
            // call delete method 
            bool wasDeleted =_menuItems.RemoveItemFromList(input);
            // say it was delete 
            if (wasDeleted)
            {
                Console.WriteLine("Meal has been deleted");
            }
            else
            {
                Console.WriteLine("Meal couldnt be deleted");
            }
            //otherwise say it couldnt 
        }
        private void SeedContentList()
        {
            Menu hamburger = new Menu("hamburger", "Regular Hamburger nothing special about it.", 1, IngredientList.Beef, 5.99);
            Menu sandwhich = new Menu("Sandwhich", "Sandwhich on Rye.", 2, IngredientList.Chicken, 7.99);
            Menu wrap = new Menu("Wrap", "Flour tortilla used to wrap your choice of protein", 3, IngredientList.Fish, 9.99);
            Menu dinnerPlate = new Menu("Dinner Plate", "Your choice of protein with mashed potatoes and a salad", 4, IngredientList.Steak, 14.99);

            _menuItems.AddMenuItemToList(hamburger);
            _menuItems.AddMenuItemToList(sandwhich);
            _menuItems.AddMenuItemToList(wrap);
            _menuItems.AddMenuItemToList(dinnerPlate);
        }
    }
}
