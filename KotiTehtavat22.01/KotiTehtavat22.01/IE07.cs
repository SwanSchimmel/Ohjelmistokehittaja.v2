using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE07
    {
        public static void Run()
        {
            char ch = Console.ReadLine()[0];

            if (char.IsLetter(ch))
                Console.WriteLine("Letter");
            else
                Console.WriteLine("Not a letter");
        }
    }
}
