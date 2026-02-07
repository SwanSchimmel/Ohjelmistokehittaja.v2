using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaProektini
{
    internal class teh1
    {
        public static void Run()
        {
            Console.Write("Numero y: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int y))
            {
                y = 5;
            }

            int x = y + 3;

            Console.WriteLine("y = " + y + ";");
            Console.WriteLine("x = " + x + ";");
        }
    }
}

//Напишите программу, которая запрашивает у пользователя значение y и
//выдает следующие результаты: y = 5; вычислить x = y + 3; вывести x = 8