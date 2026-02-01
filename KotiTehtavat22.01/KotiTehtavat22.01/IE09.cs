using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE09
    {
        public static void Run()
        {
            char ch = Console.ReadLine()[0];

            if (char.IsLetter(ch))
                Console.WriteLine("Letter");
            else if (char.IsDigit(ch))
                Console.WriteLine("Digit");
            else
                Console.WriteLine("Special character");
        }
    }
}
