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
            SeedCarList();
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
                    "2.View All Cars\n" +
                    "3.Update Cars\n" +
                    "4.Delete Car from List\n" +
                    "5.Exit");

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
                        UpdateExistingCars();
                        break;
                        // delete car on list 
                    case "4":
                        DeleteCars();
                        break;
                        //exit
                    case "5":
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
            Console.Clear();
            List<Car> listOfCars = _contentRepo.GetCarList();
            foreach(Car content in listOfCars)
            {
                Console.WriteLine($"Car Name: {content.CarMake}\n" +
                    $"Desc: {content.Description}");
            }
        }
        
        
        // Update existing cars
        private void UpdateExistingCars()
        {
            ViewAllCars();
            Console.WriteLine("Enter the car you want to update:");
            string oldCar = Console.ReadLine();
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
            bool wasUpdated = _contentRepo.UpdateCar(oldCar, newCar);

            if(wasUpdated)
            {
                Console.WriteLine("Car was successfully updated!");
            }
            else
            {
                Console.WriteLine("Car was not updated!");
            }
        }
        // delete cars 
        private void DeleteCars()
        {
            ViewAllCars();
            Console.WriteLine("\nEnter the name of the car you want to remove");
            string input = Console.ReadLine();
            bool wasDeleted = _contentRepo.RemoveCarFromList(input);
            if(wasDeleted)
            {
                Console.WriteLine("The car was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The car could not be deleted.");
            }
        }
        private void SeedCarList()
        {
            Car Tesla = new Car("Tesla", "Coupe", EngineType.Electric, "Elon Musks pride and joy");
            Car Chevy = new Car("Chevy", "Volt", EngineType.Hybrid, "Chevy's take on a hybrid");
            Car Audi = new Car("Audi", "A5", EngineType.Gas, "Audis midsize sedan with turbo");

            _contentRepo.AddCarToMainMenu(Tesla);
            _contentRepo.AddCarToMainMenu(Chevy);
            _contentRepo.AddCarToMainMenu(Audi);

        }
    }
}
