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
            Console.WriteLine(". Дана последовательность действительных чисел a1, a2, ..., an. Выяснить, будет ли она возрастающей.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());
            Console.WriteLine("В ведите последовательность ");


            int[] a = new int[dlinn];
            int vtoroe=0;
            int pervoe = 0;
            int kolvo = 0;
          
            for (  int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("   ");
                  Console.WriteLine("   ");
                  Console.WriteLine("   ");
 for (  int i = 0; i < dlinn-1; i++)
            {
                pervoe = a[i ];
                vtoroe = a[i+1];
     


     if (pervoe<=vtoroe)
     { kolvo = kolvo + 1; }
     else
     { Console.WriteLine("Последовательность не возростающий ");
     break;
     }

     if (kolvo == dlinn-1)
     {Console.WriteLine("Последовательность  возростающия ");}


            }
            Console.ReadKey();
        }
    }
}
