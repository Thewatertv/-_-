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
            Console.WriteLine("20. Дан одномерный массив A[N]. Найти:  mаx(а2, а4, ..., a2k) + min(а1, а3, …, a2k-1).");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());
            Console.WriteLine("В ведите последовательность ");


            int[] a = new int[dlinn];
            int vtoroe = 0;
            int pervoe = 0;
            int kolvo = 0;
            int pervoe1 = 0;

            for (int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            pervoe1 = a[0];
            pervoe = a[0];
            for (int i = 0; i < dlinn - 1; i++)
            {
                
                vtoroe = a[i + 1];



                if (pervoe <= vtoroe)
                { pervoe = vtoroe; }



                if (pervoe1 >= vtoroe)
                { pervoe1 = vtoroe; }


            }
            Console.WriteLine("MAX="+pervoe);
            Console.WriteLine("MIN=" + pervoe1);

            Console.ReadKey();
        }
    }
}
