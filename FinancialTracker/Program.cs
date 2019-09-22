/************************ FINANCIAL TRACKER ************************
 * Author: Brandon Barnett
 * Date: September 22, 2019
 * Description: Simple console application for tracking,
 *     adding, and removing debt.
 ******************************************************************/
using System;

namespace FinancialTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu displayMenu = new DisplayMenu();
            displayMenu.Menu();
        }
    }
}
