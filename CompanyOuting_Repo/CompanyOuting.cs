using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutingMain
{
    public enum EventType
    {
        Golf = 1,
        Bowling,
        AmusementPark,
        Concert
    }
    public class CompanyOuting
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfAttendees { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCostOfEvent { get; set; }

        public CompanyOuting() { }
        public CompanyOuting(EventType eventType, int numberOfAttendees, DateTime dateOfEvent, double costPerPerson, double totalCostOfEvent)
        {
            TypeOfEvent = eventType;
            NumberOfAttendees = numberOfAttendees;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            TotalCostOfEvent = totalCostOfEvent;
        }
    }
}

