using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("8. С клавиатуры вводится целое число. Вывести на экран все числа, на которые введённое число делится без остатка. Например, для 60 такими числами станут 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60.");

            Console.WriteLine("Введите число");
            int M = int.Parse(Console.ReadLine());

            for (int i=1; i<=M;i++)
            {if (M%i==0)
                {Console.WriteLine("Делится без остатка на "+i);}
            }
          
            Console.ReadKey();
        }
    }
}
