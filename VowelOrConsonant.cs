
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_program
{
    public class VowelOrconsonant
    {
        public static void CheckVowelOrconsonant()
        {
            char ch;
            Console.WriteLine("enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("alphabet is vowel");
            }
            else
            {
                Console.WriteLine("alphabet is consonant");
            }
        }
    }
}
