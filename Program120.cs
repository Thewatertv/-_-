using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("120. Задана квадратная матрица. Получить транспонированную матрицу, т.е. матрицу, где столбцы и строки меняются местами.");
            Console.WriteLine("В ведите количесво элементов NxM");
            int N = 0;
            int M = 0;
            string str = Console.ReadLine();
            string stl = Console.ReadLine();
            N = int.Parse(str);
            M = int.Parse(stl);


             Console.WriteLine("Исходная матрийа");
                     Console.WriteLine();
             int[,] sample =new int [N,M];
            Random rnd = new Random();

            for (int i=0;i<N;i++)
            {

                for (int j=0;j<M;j++)
                {
                    sample[i, j] = rnd.Next(1, 100);
                    Console.Write(sample[i, j] + "\t");
                }
                 Console.WriteLine();
            }
            int[,] trans =new int [M,N];
              Console.WriteLine();
              Console.WriteLine("Транспонированая матрийа");
                    Console.WriteLine();
                    for (int i = 0; i < N; i++)
                    {
            for(int j=0;j<N;j++)
            {

                trans[i,j]=sample[j,i];
                Console.Write(trans[i, j] + "\t");
            }
            Console.WriteLine();
            }
              Console.ReadLine();
        }
      
    }
}
