using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public static class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;
            double headpercentage;
            double tailpercentage;
            Console.WriteLine("enter the value for number of flip");
            int Flipcoin = Convert.ToInt32(Console.ReadLine());
            if (Flipcoin > 0)
            {
                for (int i = 0; i < Flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(0, 2);
                    Console.WriteLine("The Flip is" + number);
                    if (number == 1)
                    {
                        headcount++;
                    }
                    else
                    {
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / Flipcoin;
                tailpercentage = tailcount * 100 / Flipcoin;
                Console.WriteLine("The headpercentage is" + headpercentage);
                Console.WriteLine("The tailpercentage is" + tailpercentage);

            }

        }
    }
}
