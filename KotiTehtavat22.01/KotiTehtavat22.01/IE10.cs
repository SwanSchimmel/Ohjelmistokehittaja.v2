using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE10
    {
        public static void Run()
        {
            char ch = Console.ReadLine()[0];

            if (char.IsUpper(ch))
                Console.WriteLine("Uppercase");
            else if (char.IsLower(ch))
                Console.WriteLine("Lowercase");
        }
    }
}
