using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlan_Repo
{
    public enum EngineType
    {
       Gas = 1,
       Electric,
       Hybrid,
    }
   public class Car
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public EngineType EngineType { get; set; }
        public string Description  { get; set; }
        public Car() { }
        public Car(string carMake, string carModel, EngineType engineType, string carDescription)
        {
            CarMake = carMake;
            CarModel = carModel;
            EngineType = engineType;
            Description = carDescription;
        }

   }
}

