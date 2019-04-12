using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 2, 4, 4, 6, 6, 9 };
            int k = 0;
            List<int> numbers = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    k = array[i];
                    numbers.Add(k);
                }
                else continue;
                k = 0;
            }

            int[] numbers2 = numbers.ToArray<int>();

            foreach (int s in numbers2)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}
