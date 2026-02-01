using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotiTehtavat22._01
{
    internal class IE11
    {
        public static void Run()
        {
            int costPrice = int.Parse(Console.ReadLine());
            int sellingPrice = int.Parse(Console.ReadLine());

            if (sellingPrice > costPrice)
                Console.WriteLine("Profit");
            else if (sellingPrice < costPrice)
                Console.WriteLine("Loss");
            else
                Console.WriteLine("No profit no loss");
        }
    }
}
