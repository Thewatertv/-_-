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
            Console.WriteLine("75. Сортировка вставками. Дана последовательность чисел а1, а2, ..., аn. Требуется переставить числа в порядке возрастания. Делается это следующим образом. Пусть а1, а2, ..., аi – упорядоченная последовательность, т.е. a1 ≤ a2 ≤ ... ≤ аi. Берется следующее число ai+1 и вставляется в последовательность так, чтобы новая последовательность была также возрастающей. Процесс производится до тех пор, пока все элементы от i+1 до n не будут перебраны.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());



            Console.WriteLine("В ведите последовательность ");
            int[] a = new int[dlinn];

            int noll, pologitel, otritzal;
            noll = 0; pologitel = 0; otritzal = 0;


            for (int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());






            }


            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int z = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = z;
                    }


                }

            }


            for (int i1 = 0; i1 < dlinn; i1++)
            {

                Console.Write(a[i1]);
                Console.Write("  ");






            }


            Console.ReadKey();
        }
    }
}

