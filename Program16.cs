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
            Console.WriteLine(" 16. Какой-то чувак купил N куриц по M рублей за одну курицу. Каждая курица несёт по X яиц в неделю. Чувак решил открыть свой бизнес и стал продавать яйца, которые несут курицы. За сколько дней окупятся куры, если продавать яйца по Z рублей за десяток (с учётом НДС)? Сроком жизни куриц, влажностью воздуха в курятнике, а также скоростью ветра и фазами луны можно пренебречь. ");
           // Random rnd = new Random();
            double wan_rub, dney; dney = 0;
            //int x = rnd.Next(1, 10);
            Console.WriteLine("Сколько куриц купил?");
            double kurez = double.Parse(Console.ReadLine());

            Console.WriteLine("За сколько рублей");
            double rub = double.Parse(Console.ReadLine());
             Console.WriteLine("Сколько яиц несет курицав неделю?");
             double kolvo = double.Parse(Console.ReadLine());
           
             Console.WriteLine("За сколько он продает десяток яиц?");
             double prodaha = double.Parse(Console.ReadLine());

            rub=rub*kurez;//цена куриц
          
            kolvo=kolvo*kurez;
            kolvo = kolvo / 7;//яиц в неделю
           
            wan_rub=prodaha/10;//цена за 1 яйцо
         
            wan_rub=wan_rub*kolvo;
          


            for (double I = 0; rub > wan_rub; )
            { wan_rub = wan_rub + wan_rub;
            I = I + 1;
            dney = I;
            
            }



            Console.WriteLine("Понадобится дней =" + dney);
            
            Console.ReadKey();

        }
    }
}
