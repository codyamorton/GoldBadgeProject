using GreenPlan_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlan_Console
{
    class ProgramUI
    {
        private CarRepo _contentRepo = new CarRepo();
        public void Run()
        {
            Menu();
        }
        // menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Select a Menu Option:\n" +
                    "1.Create New Car\n" +
                    "2.Add Car to List\n" +
                    "3.Update Car on List\n" +
                    "4.View Car Description\n" +
                    "5.Delete Car from List\n" +
                    "6.Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    // Create new car
                    case "1":
                        CreateNewCars();
                        break;
                        // add car to list 
                    case "2":
                        ViewAllCars();
                        break;
                        // update car on list 
                    case "3":
                        ViewCarDescription();
                        break;
                        // view car on list 
                    case "4":
                        UpdateExistingCars();
                        break;
                        // delete car on list 
                    case "5":
                        DeleteCars();
                        break;
                        //exit
                    case "6":
                        Console.WriteLine("GoodBye!!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                
            }
        }
    //Create new car 
        private void CreateNewCars()
        {
            Console.Clear();

            Car newCar = new Car();
            Console.WriteLine("Enter the make of the car you want to add:");
            newCar.CarMake = Console.ReadLine();

            Console.WriteLine("Enter the model of the car you want to add:");
            newCar.CarModel = Console.ReadLine();

            Console.WriteLine("Enter the description for the car you are adding:");
            newCar.Description = Console.ReadLine();

            Console.WriteLine("Enter the number for which engine type the car has:\n" +
                "1.Gas\n" +
                "2.Electric\n" +
                "3.Hybrid");

            string engineAsString = Console.ReadLine();
            int engineAsInt = int.Parse(engineAsString);
            newCar.EngineType = (EngineType)engineAsInt;

            _contentRepo.AddCarToMainMenu(newCar);


        }
        // view current cars that are saved
        private void ViewAllCars()
        {
            List<Car> listOfCars = _contentRepo.GetCarList();
        }
        
        // view existing cars description
        private void ViewCarDescription()
        {

        }
        // Update existing cars
        private void UpdateExistingCars()
        {

        }
        // delete cars 
        private void DeleteCars()
        {

        }

    }
}
