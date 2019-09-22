using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker
{
    public class DisplayMenu
    {
        public void Menu()
        {
            string choice = string.Empty;
            while (choice != "7")
            {
                Console.WriteLine("******** WELCOME TO YOUR FINANCE TRACKER ********");
                Console.WriteLine("1) See total debt.");
                Console.WriteLine("2) Add credit card debt.");
                Console.WriteLine("3) Add vehicle loan.");
                Console.WriteLine("4) Add student loan.");
                Console.WriteLine("5) Remove debt.");
                Console.WriteLine("6) Save entries.");            // Will be implemented later.
                Console.WriteLine("7) Quit.");
                Console.Write("Please select one of the options: ");
                choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Your total debt is: ");
                        ContinueAndClear.ClearScreen();
                        break;
                    case "2":
                        Console.WriteLine("This is where you will any credit card debt you may have.");
                        ContinueAndClear.ClearScreen();
                        break;
                    case "3":
                        Console.WriteLine("This is where you can add any vehicle loans you may have.");
                        ContinueAndClear.ClearScreen();
                        break;
                    case "4":
                        Console.WriteLine("This is where you can add student loans.");
                        ContinueAndClear.ClearScreen();
                        break;
                    case "5":
                        Console.WriteLine("Have you paid off a debt?  You can remove them here from the list.");
                        ContinueAndClear.ClearScreen();
                        break;
                    case "6":
                        Console.WriteLine("This will save the debt entries to a file."); 
                        ContinueAndClear.ClearScreen();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Please select from one of the options or press 7 to quit.");
                        break;
                }

            }
        }
    }
}
