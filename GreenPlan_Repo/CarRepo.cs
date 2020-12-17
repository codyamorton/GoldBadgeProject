using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlan_Repo
{
   public class CarRepo
    {
        private List<Car> _mainMenuItems = new List<Car>();

        // create
        public void AddCarToMainMenu(Car mainMenuItem)
        {
            _mainMenuItems.Add(mainMenuItem);
        }

        // read
        public List<Car> GetCarList()
        {
            return _mainMenuItems;
        }
        // Update Car 
        public bool UpdateCar(string originalCar, Car newCarMake)
        {
            // Find Car
            Car oldCarMake = GetCarByTitle(originalCar);
            // update car
            if (oldCarMake != null)
            {
                oldCarMake.CarMake = newCarMake.CarMake;
                oldCarMake.CarModel = newCarMake.CarModel;
                oldCarMake.EngineType = newCarMake.EngineType;
                oldCarMake.Description = newCarMake.Description;

                return true;
            }
            else
            {
                return false;
            }    
        }

        public bool RemoveCarFromList(string carMake)
            {
                Car mainMenuItem = GetCarByTitle(carMake);
                    if(mainMenuItem == null)
                {
                    return false;
                }
                int initialCount = _mainMenuItems.Count;
                _mainMenuItems.Remove(mainMenuItem);

                if(initialCount > _mainMenuItems.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             }
        
        // helper 
        private Car GetCarByTitle (string carMake)
        {
            foreach (Car mainMenuItem in _mainMenuItems)
            {
                if (mainMenuItem.CarMake == carMake)
                {
                    return mainMenuItem;
                }
            }

            return null;
        }
    }   
}

