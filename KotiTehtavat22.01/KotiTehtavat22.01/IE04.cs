using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE04
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0 || n % 11 == 0)
                Console.WriteLine("Divisible");
            else
                Console.WriteLine("Not divisible");
        }
    }
}
