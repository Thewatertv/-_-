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
            Console.WriteLine("Дан массив натуральных чисел. Найти сумму элементов, кратных данному K ");


            int[] arr = { 1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14,15,16,17,18,19 };

            Console.WriteLine("Ведите K ");
            int k = int.Parse(Console.ReadLine());
            int g = 0;
            for (int i = 1; i <19; i++)
            {
                if (arr[i] % k == 0)
                { g = g + arr[i];
              
                }



           
                
                          
               
            }


          

            
            Console.Write(g);


            Console.ReadKey();

        }
    }
}
