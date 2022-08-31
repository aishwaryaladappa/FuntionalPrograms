using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class LargestNumber
    {
        public static void CheckLargestNumber()
        {
            int a, b, c;
            Console.WriteLine("enter the a value:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the b value:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the c value:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a value is greater than b and c:" + a + b +
                    c);

            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b value is greater than a and c:" + b + a + c);

            }
            else
            {
                Console.WriteLine("a value is greater than b and c:" + a + b + c);


            }
        }
    }
}
