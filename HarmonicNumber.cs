using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class HarmonicNumber
    {
        public static void DisplayHarmonicNumber()
        {
            int i, n, Value = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {

                Console.Write("(1 /{0}) +", i);

            }
        }
    }
}