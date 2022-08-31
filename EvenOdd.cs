using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public static class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            int number;
            Console.WriteLine("enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("number is even number");

            }
            else
            {
                Console.WriteLine("number is odd number");
            }


        }

    }
}
