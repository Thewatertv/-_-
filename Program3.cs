using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ежемесячная стипендия студента составляет N рублей, а расходы на проживание превышают стипендию и составляют M рублей в месяц. Рост цен ежемесячно увеличивает расходы на 3%. Составьте программу расчёта суммы денег, которую необходимо единовременно попросить у родителей, чтобы можно было прожить учебный год (10 месяцев), используя только эти деньги и стипендию.");

            double pro, swmma; pro = 0.3; swmma = 0;
            Console.WriteLine("Скольки равна стипендия");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Расходы на проживния превышают стипендию на ");
            double m = double.Parse(Console.ReadLine());
            m = m + n;
            swmma = m;
            for (int i = 0; i >= 10;i++ )
            {
                m = m * pro + m;
                swmma = swmma + m;
            }
            n = n * 10;
            swmma = swmma - n;
            Console.WriteLine("У родителей надо попросить " + swmma);
                Console.ReadKey();

        }
    }
}