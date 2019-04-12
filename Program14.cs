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

            Console.WriteLine("15.	Вывести лестницу из отрезков определённой длины. Длина (например, 14) и количество ступенек (например, 4) указывается с клавиатуры.");

            Console.WriteLine("Введите Длину ");
            int dlin = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите колво ступенек ");
            int stupen = int.Parse(Console.ReadLine());
            int otstup = 0;
       
            for (int i =1;i<=stupen;i++)
            {

                for (int l = 1; l <= otstup; l++)
                {


                    Console.Write(" ");
                }


                for (int I = 1; I <= dlin;I++ )
                {

                 

                    Console.Write("*");
                }


                Console.WriteLine();
                    otstup = otstup + 1;
            }


            Console.ReadKey();

        }
    }
}
