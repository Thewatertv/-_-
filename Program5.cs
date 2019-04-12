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

            Console.WriteLine("Показать на экране равнобедренный треугольник (пользователь вводит высоту). Затем сделать то же самое, но чтоб фигура внутри была пустая (остаётся только контур)..");

            Console.WriteLine("Введите высоту ");
            int m = int.Parse(Console.ReadLine());
            int v, x, vtoroe;
            vtoroe=m;
            v = m;
            x = m-1;




             int seruduna =0;
            for (int i = 1; i <= m;i++ )
            {
                Console.WriteLine(" ");

                for (int h = 1;h <= m ;h++ )
                {
                    if (seruduna == v / 2 | seruduna == x/2)
                    { Console.Write("*"); }

                    Console.Write(" ");

                   
                  
                seruduna=seruduna+1;

                }
                x = x - 1;
                v = v + 1;
                seruduna = 0;

            }
            Console.WriteLine(" ");
            for (int Y = 0; Y <= m; Y++)
            {
                Console.Write("*");
                Console.Write("");
                 }




            Console.WriteLine(" ");
            Console.WriteLine(" ");




            int v2, x2;
            v2 = vtoroe;
            x2 = vtoroe - 1;




            int seruduna2 = 0;
            for (int i2 = 1; i2 <= vtoroe; i2++)
            {
                Console.WriteLine("   ");

                for (int h2 = 1; h2 <= vtoroe; h2++)
                {
                    
                    if ( seruduna2 >= x2 / 2 )
                    { Console.Write("*"); }
                    Console.Write( " ");
                    

                    if (seruduna2 == v2 / 2 )
                    { break; }

                    seruduna2 = seruduna2 + 1;
                 

                }
                x2 = x2 - 1;
                v2 = v2 ;
                seruduna2 = 0;

            }
            Console.WriteLine(" ");
            for (int Y = 0; Y <= vtoroe; Y++)
            {
                Console.Write("*");
                Console.Write("");
            }







                Console.ReadKey();

        }
    }
}
