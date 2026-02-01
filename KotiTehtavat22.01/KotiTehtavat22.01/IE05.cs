using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE05
    {
        public static void Run()
        {
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not a leap year");
        }
    }
}
