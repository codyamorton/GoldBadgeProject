using GreenPlan_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GreenPlan_Test
{
    [TestClass]
    public class GreenPlanTest
    {
        [TestMethod]
        public void SetCarMake()
        {
            Car carMake = new Car();

            carMake.CarMake = "Tesla";
            string expected = "Tesla";
            string actual = carMake.CarMake;

            Assert.AreEqual(expected, actual);
        }
    }
}
