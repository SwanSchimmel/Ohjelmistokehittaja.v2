using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE08
    {
        public static void Run()
        {
            char ch = char.ToLower(Console.ReadLine()[0]);

            if ("aeiou".Contains(ch))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
