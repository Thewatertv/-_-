using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
       
        public static bool CheckNumber(int num)
        {
           // Console.WriteLine("11. Показать на экране все совершенные числа в диапазоне от 0 до 10.000.000");


           int sum=1;
           for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;
           return (sum == num);
            

    }

        static void Main(string[] args)
        {

            int N = 100000000;
        


            for (int i = 1; i < N; i++)
                if (CheckNumber(i)) Console.WriteLine(i.ToString() + "Совершеное число");
               
            Console.ReadKey();


        }
}
}