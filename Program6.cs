using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. С клавиатуры вводится целое число любой разрядности. Определить количество цифр в нём и их сумму.  ");
            int number = int.Parse(Console.ReadLine());
            int d = number; int counter = 0; int summa = 0;

            while (number != 0)
            {
                number = number / 10;
                counter = counter + 1;
            }
            Console.WriteLine("Разрядов в числе  " + counter);
            for (int i = 1; i <= counter; i++)
            {
                summa = summa + (d % 10);
                d = d / 10;
            }
            Console.WriteLine("Сумма цифр = " + summa);
            Console.ReadKey();
        }
    }
}