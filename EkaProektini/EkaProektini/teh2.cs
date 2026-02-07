using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaProektini
{
    internal class teh2
    {
        static public void Run()
        {
            string z = Console.ReadLine("Numero: ");
            int y = Convert.ToInt32(z);
            
            int x = y - 2;
            Console.WriteLine($"{x}");
        }
    }
}

//Напишите программу, которая запрашивает у пользователя значение y и
//выдает следующие результаты: y = 5; вычислить x = y - 2; вывести x = 3 