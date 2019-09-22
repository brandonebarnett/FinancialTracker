using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker
{
    public class TotalDebt
    {
        double vehicleLoan;
        double studentLoan;
        double creditCard;
        public void CalculateDebt()
        {
            Console.WriteLine("You are debt free.");
        }

        public void CalculateVehicleDebt(double vehicleLoan)
        {
            double result = vehicleLoan;
            Console.WriteLine("Your total debt is: " + result);
        }

        public void CalculateStudentDebt(double studentLoan)
        {
            double result = studentLoan;
            Console.WriteLine("Your total debt is: " + result);
        }

        public void CalculateCreditDebt(double creditCard)
        {
            double result = creditCard;
            Console.WriteLine("Your total debt is: " + result);
        }
    }
}
