using GreenPlan_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GreenPlan_Test
{
    [TestClass]
    public class GreenPlanRepoTest
    {
        private Car _repo;
        private Car _carInfo

        [TestInitialize]
        public void Arrange()
        {
            _repo = new Car();
            _carInfo = new Car("Tesla", "Roadster", EngineType.Electric);

            _repo.AddCarToMainMenu(_carInfo);
        }

        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //Arrange
            Car carMake = new Car();
            carMake.CarMake = "Tesla";
            Car repository = new Car();
            //Act
            repository.AddCarToMainMenu(carMake);
            Car carFromList = repository.GetCarByTitle("Tesla");
            //Assert
            Assert.IsNotNull(carFromList);
        }
        // update 
        [TestMethod]
        public void UpdateCarList()
        {
            // Arrange
            // TestInitialize
            Car newCar = new Car("Tesla", "Roadster", EngineType.Electric);
            //Act
            bool updateList = _repo.UpdateCar("Tesla", newCar);
            // Assert
            Assert.IsTrue(updateList);
        }
        [DataTestMethod]
        [DataRow("Tesla", true)]
        [DataRow("Chevy", false)]
        public void UpdateExistingCarList(string orginalCarList, bool shouldUpdate)
        {
            Car newCar = new Car("Tesla", "Roadster", EngineType.Electric);
            //Act
            bool updateList = _repo.UpdateCar("Tesla", newCar);
            // Assert
            Assert.AreEqual(shouldUpdate, updateList);
        }

        [TestMethod]
        public void DeleteCars()
        {
            bool deleteResult = _repo.RemoveCarFromList(_carInfo.CarMake);
            Assert.IsTrue(deleteResult);
        }
        
    }
}
