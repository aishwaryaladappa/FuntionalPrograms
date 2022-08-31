using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class QuotientReminder
    {
        public static void CalculateQuotietAndRemainder()
        {
            int dividend = 100;
            int devisor = 25;
            int quotient = dividend / devisor;
            int reminder = dividend % devisor;
            Console.WriteLine("Dividend:" + dividend + "Divisor:" + devisor);
            Console.WriteLine("Quotient:" + quotient);
            Console.WriteLine("Reminder:" + reminder);
        }
    }
}
