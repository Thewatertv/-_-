using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("7. Определить, является ли введённое число любой разрядности палиндромом (например, 1234321 – палиндром, 12345 – не палиндром).");

            Console.WriteLine("Введите число ");
            string number = Console.ReadLine();
            bool palindrom = true;
            //Свойство String.Length Возвращает число знаков в текущем объекте String.
            for (int i = 0; i < (number.Length - 1) / 2;i++ )
            { if (number[i]!=number[number.Length -i -1])
                palindrom = false;
            }

            if (palindrom)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");

                Console.ReadKey();

        }
    }
}
