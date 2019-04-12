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
            Console.WriteLine("Дан массив действительных чисел, размерность которого N. Подсчитать, сколько в нем отрицательных, положительных и нулевых элементов.");
            Console.WriteLine("В ведите длину последовательность ");
            int dlinn = int.Parse(Console.ReadLine());


        
            Console.WriteLine("В ведите последовательность ");
            int[] a = new int[dlinn];
          
             int noll,pologitel,otritzal;
            noll=0;pologitel=0;otritzal=0;


            for (int i = 0; i < dlinn; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            



 if (a[i] == 0)
                    noll = noll + 1;
                {
                    if (a[i]> 0)
                    { pologitel = pologitel + 1;  }
                    {
                        if (a[i] < 0)
                            otritzal = otritzal + 1;
                    }
                }

              }

            
         
            Console.WriteLine("Процент положиетльных = "+pologitel);
            Console.WriteLine("Процент отрицательных " +  otritzal );
            Console.WriteLine("Процент равных 0 = " + noll );
                Console.ReadKey();
         }
        }
    }

