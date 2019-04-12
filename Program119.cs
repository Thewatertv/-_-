using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {

        static bool isMagig(int[,] arr)
        {

            if (arr.GetLength(0) != arr.GetLength(1))
                return false;



            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int summRow = 0;
                int summCol = 0;
                int summDiag1 = 0;
                int summDiag2 = 0;



                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summRow += arr[i, j];
                    summCol += arr[j, i];
                    summDiag1 += arr[j, j];
                    summDiag2 += arr[arr.GetLength(0) - 1 - j, arr.GetLength(1) - 1 - j];

                }
                if (summRow != summCol || summRow != summDiag1 || summRow != summDiag2)
                    return false;


            }

            return true;





        }
            static void Main()
            {int [,]magic ={{15,5,9,4},{3,10,6,15,},{2,11,7,14},{13,8,12,1}};
                int [,]notMagic={{16,5,9,4},{3,11,6,15,},{2,11,7,14},{13,8,12,1}};
                
                Console.WriteLine(isMagig(magic));
                    
                 Console.WriteLine(isMagig(magic));
                 Console.WriteLine(true);

                 Console.ReadKey();




        }
    }
}