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

            Console.WriteLine("Написать программу, которая выводят на экран ромб (длины диагоналей ромба одинаковы по значению, но могут быть равны любому числу). Затем сделать то же самое, но чтоб фигура внутри была пустая (остаётся только контур).");

            Console.WriteLine("Введите Длину лиагонали ромба");
            int i = int.Parse(Console.ReadLine());

            int  j, N=i ;
            j = i;
           
            int center = N / 2;
            for (i = 0; i < N;i++ )
            {
                for (j=0;j<N;j++)
                {

                    if (i<=center)
                    {
                        if (j >= center - i && j <= center + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i-N+1 && j <= center - i+N-1)
                            Console.Write("*");
                        else
                            Console.Write(" ");



                    }

                }
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            int j2, N2 = i;
            j2 = i;

            int center2 = N2 / 2;
            for (i = 0; i < N2; i++)
            {
                for (j2 = 0; j2 < N2; j2++)
                {

                    if (i <= center2)
                    {
                        if (j2 == center2 - i | j2 == center2 + i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j2 == center2 + i - N2 + 1 | j2 == center2 - i + N2 - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");



                    }

                }
                Console.WriteLine();

            }

                Console.ReadKey();

        }
    }
}
