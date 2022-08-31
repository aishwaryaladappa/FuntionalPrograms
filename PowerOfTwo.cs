using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class PowerOfTwo
    {
        public static void CalculatePwowerOfTwo()
        {
            int limit, number, i, mul;
            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= limit; i++)
            {
                mul = number * i;
                Console.WriteLine("power of two is" + mul);
            }

        }


    }
}
