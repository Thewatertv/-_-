using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_34
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 = +2; 2 = -1
            
            int[] array = new int[30] { 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, };

            Console.WriteLine("Введите высоту дерева");
            int vus = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите на каком расстоянии находится улитка");
            int sum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == 0) sum = sum + 2;
                else sum = sum - 1;
            }

            if (vus < sum)
            {
                Console.WriteLine("Высота дерева " + vus);
                Console.WriteLine("Улитка прошла " + sum); 
                Console.WriteLine("Длина дерева меньше, чем прошла улитка");
            }
            else 
            {
                Console.WriteLine("Высота дерева " + vus);
                Console.WriteLine("Улитка прошла " + sum); 
            }

            Console.ReadKey();
        }
    }
}
