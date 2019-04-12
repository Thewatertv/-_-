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
            Console.WriteLine(" 17. Реализовать игровую программу «Однорукий бандит» (игровой автомат). В начале игры пользователю выдаётся кредит на 5000 рублей. Случайным образом на барабанчиках выпадает три значения от 0 до 7. Призовые комбинации: 0 0 0, 1 1 1, 2 2 2, 3 3 3, 4 4 4, 5 Х Х, 5 5 Х, 5 5 5, 7 Х Х, 7 7 Х, 7 7 7 (на месте Х может быть любая цифра). Штрафная комбинация: 6 6 6. Все остальные комбинации нейтральные. В любом случае, за показ новой комбинации с игрового счёта пользователя снимается определённая фиксированная сумма денег. Необходимо назначить различные вознаграждения за выпадение призовых комбинаций. Зациклить работу приложения. Игра заканчивается поражением, если деньги закончились. Игра заканчивается победой, если выпадает джек-пот (7 7 7).");
             Random rnd = new Random();
           int bank, liboe_hero1,liboe_hero2;bank =500;liboe_hero1=0;liboe_hero2=0;
           
            for (int i = 0; bank>0; i++) // цикл выполнится 5 раз
            {
                
                Console.WriteLine("" );
                int x1 = rnd.Next(1, 7);
                int x2 = rnd.Next(1, 7);
                int x3 = rnd.Next(1, 7);

                Console.WriteLine("");

                if (x1 == 7 && x2 == 7 && x3 == 7)
                    Console.WriteLine("Вы выбили джекпот");
                else
                {if (x1 == 6 && x2 == 6 && x3 == 6)
                { Console.WriteLine("Выпала штрафная комбинация - 1/2 банка");bank=bank/2;}
                else
                { if (x1 == 7 && x2 == x3 && x3 == x1)
                { Console.WriteLine("Нейтральная комбинайция вы получате +100 руб к банку");bank=bank+100;}
                else {if (x1 == 5 )
                { Console.WriteLine("Выпала комбинация  5 Х Х +100 руб к банку"); bank = bank + 100; }
                else {if (x1 == 5 && x2==5)
                { Console.WriteLine("Выпала комбинация  5 5 Х +100 руб к банку"); bank = bank + 100; }
                else
                {
                    if (x1 ==7  )
                    { Console.WriteLine("Выпала комбинация  7 X Х +100 руб к банку"); bank = bank + 100; }
                    else
                    {
                        if (x1 == 7 && x2 == 7)
                        { Console.WriteLine("Выпала комбинация  7 7 Х +100 руб к банку"); bank = bank + 100; }
                        else
                        {
                            if (x1 == x2 && x2 == x3 & x1==x3)
                            { Console.WriteLine("Вы  получаете  +100 руб к банку"); bank = bank + 100; }
                            else
                            {
                                if (x1 != x2 && x2 != x3 && x1 != x3)
                                { Console.WriteLine("Вы проиграли   -100 руб к банку"); bank = bank - 100; }
                                Console.ReadKey();

                            }
                        }
                    }
                }
                }}}
                
                }
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                Console.WriteLine(x3);
                Console.WriteLine("У вас на счету=" + bank);
                Console.WriteLine("");
                }
            Console.WriteLine("У вас закончились деньги");
            Console.ReadKey();

        }
    }
}
