using CompanyOutingMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOuting_Repo
{
    public class CompanyOuting_Repo
    {
        private List<CompanyOuting> _listOfOutings = new List<CompanyOuting>();
        public void AddOutingToList(CompanyOuting content)
        {
            _listOfOutings.Add(content);
        }
        public List<CompanyOuting> GetCompanyOutingsList()
        {
            return _listOfOutings;
        }

        //update
        public void UpdateExistingContent(EventType originalTitle, CompanyOuting newContent)
        {
            CompanyOuting oldContent = NameOfOuting(originalTitle);
            if (oldContent != null)
            {
                oldContent.TypeOfEvent = newContent.TypeOfEvent;
                oldContent.DateOfEvent = newContent.DateOfEvent;
                oldContent.CostPerPerson = newContent.CostPerPerson;
                oldContent.NumberOfAttendees = newContent.NumberOfAttendees;
                oldContent.TotalCostOfEvent = newContent.TotalCostOfEvent;
            }
        }
        public bool RemoveOutingFromList(EventType eventTitle)
        {
            CompanyOuting content = NameOfOuting(eventTitle);
            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfOutings.Count;
            _listOfOutings.Remove(content);

            if (initialCount > _listOfOutings.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private CompanyOuting NameOfOuting(EventType typeOfEvent)
        {
            foreach (CompanyOuting content in _listOfOutings)
            {
                if (content.TypeOfEvent == typeOfEvent)
                {
                    return content;
                }

            }
            return null;
        }

    }
}
