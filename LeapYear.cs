
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class LeapYear
    {
        public static void CalculateLeapYear()
        {

            Console.WriteLine("enter a value of year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("the year is a leap year" + year);
            }
            else
            {
                Console.WriteLine("the year is not a leap year" + year);
            }




        }
    }

}
