using CompanyOutingMain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CompanyOuting_Test
{
    [TestClass]
    public class OutingTest
    {
        private CompanyOuting _repo;
        private CompanyOuting _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new CompanyOuting();
            _content = new CompanyOuting(EventType.Golf, 20, DateTime.Now, 50, 450);

            _repo.AddOutingToList(_content);
        }

        [TestMethod]
        public void SetOuting()
        {
            CompanyOuting content = new CompanyOuting();
            content.TypeOfEvent = EventType.Golf;
            EventType expected = EventType.Golf;
            EventType actual = content.TypeOfEvent;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue(EventType eventType)

        {
            new CompanyOuting(EventType.Golf, 20, DateTime.Now, 50, 450);
            bool updateResult = _repo.TypeOfEvent(EventType.Golf, EventType.Golf);

            Assert.IsTrue(updateResult);


        }
        

        
    }
}
