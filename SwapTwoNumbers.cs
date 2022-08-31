using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class SwapTwoNumbers
    {
        public static void Swapped()
        {
            int a = 10, b = 7;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("a:" + a + "b:" + b);

        }
    }
}
