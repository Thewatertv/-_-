using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        { // Console.WriteLine("12. Показать на экране все числа Фибоначчи в диапазоне от 0 до 10.000.000.");


            Int32 number = 10000000;
            int perv = 1;
            Console.Write("{0}",perv);
            int vtoroe = 1;
            Console.Write(" ");
            Console.Write("{0}", vtoroe);
            int sum = 0;

            while (number>=sum)
            {

                sum = perv + vtoroe;
                Console.Write(" ");
                Console.Write("{0}", sum);
              

                perv = vtoroe;
                vtoroe = sum;
            }


            Console.ReadKey();
        }
    }
}
