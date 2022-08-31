using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public static class PrimeFactors
    {
        public static void CalculatePrimeFactros()
        {
            int n, i;
            Console.WriteLine("enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + "is a prime factor of" + n);
                }
            }
        }
    }
}
