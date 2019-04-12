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
            Console.WriteLine("Дана последовательность действительных чисел a1, a2, ..., an. Заменить все ее члены, большие данного Z, этим числом. Подсчитать количество замен.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Ведите Z ");
            int Z= int.Parse(Console.ReadLine());
            Console.WriteLine("В ведите последовательность ");
            int[] a = new int[dlinn];
            int vtoroe = 0;
            int pervoe = 0;
            int kolvo = 0;
            int zamen = 0;
            for (int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            



            for (int i = 0; i < dlinn - 1; i++)
            {
                pervoe = a[i];
               

                if (Z< pervoe)
                { Console.WriteLine("Это больше меньше  " + a[i]+"  Чем   "+Z);
                a[i] = a[i] - Z;
                    zamen = zamen + 1;
                }

               


            }
            Console.WriteLine("Количесво замен = " + zamen);
            Console.ReadKey();
        }
    }
}
