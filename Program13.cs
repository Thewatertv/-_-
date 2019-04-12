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
            Console.WriteLine("В заданном одномерном массиве поменять местами соседние элементы, стоящие на четных местах, с элементами, стоящими на нечетных.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());
            Console.WriteLine("В ведите последовательность ");


            int[] a = new int[dlinn];
            int vtoroe = 0;
            int pervoe = 0;
            int kolvo = 0;

            for (int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            for (int i = 0; i < dlinn - 1; i += 2)
            {
                pervoe = a[i];
                vtoroe = a[i + 1];
                a[i + 1] = a[i];
                a[i] = vtoroe;



            }


            for (int i1 = 0; i1 < dlinn; i1++)
            {

                Console.Write(a[i1] + " ");
            }

            Console.ReadKey();

        }
    }
}

