using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker
{
    public static class ContinueAndClear
    {
        public static void ClearScreen()
        {
            Console.Write("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
