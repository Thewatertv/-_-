using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" В целочисленной последовательности есть нулевые элементы. Создать массив из номеров этих элементов.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());
            Console.WriteLine("В ведите последовательность ");



           
            int[] a = new int[dlinn];

            int i = 0;

            for (; i < dlinn; i++)
            {
               
                a[i] = int.Parse(Console.ReadLine());
              
            }



            for (int i1 = 0; i1 < dlinn; i1++)
            {
                         
                Console.Write(a[i1] + " ");
            }



            Console.ReadKey();

        }
    }
}
