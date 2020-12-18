using CompanyOutingMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOuting_Console
{
    class CompOutingUI
    {
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {



                Console.WriteLine("Select a menu option:\n" +
                    "1.Create new outing:\n" +
                    "2.Add outing to list:\n" +
                    "3. View outing cost by type:\n" +
                    "4.Display costs for all outings:\n" +
                    "5.Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewOuting();
                        break;
                    case "2":
                        AddOutingToList();
                        break;
                    case "3":
                        ViewOutingCostByType();
                        break;
                    case "4":
                        DisplayCostForAllOutings();
                        break;
                    case "5":
                        Console.WriteLine("GoodBye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number:");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }





        private void CreateNewOuting()
        {
            CompanyOuting newContent = new CompanyOuting();
            Console.WriteLine("Please enter the name for your outing:");
            newContent.TypeOfEvent = 
            Console.WriteLine("Enter the number of attendees");
            newContent.NumberOfAttendees = 

        }
        private void ViewOutingCostByType()
        {

        }
        private void DisplayCostForAllOutings()
        {

        }
    }
}
