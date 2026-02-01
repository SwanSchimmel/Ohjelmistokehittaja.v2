using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE03
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("Positive");
            else if (n < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
    }
}
