using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE02
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            Console.WriteLine("Biggest number is " + max);
        }
    
    }
}
