using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("12. Написать игру «Угадай число». Пользователь мысленно загадывает число от 0 до 100, компьютер отгадывает его за минимальное количество попыток.");
            Console.WriteLine("Это число больше 50?.(Еслибольше введите 1 если меньше введите 2)");
            int bollee_50 = int.Parse(Console.ReadLine());
            switch (bollee_50)
            {
                case 1:
                    //больше 50 (51-100)

                    Console.WriteLine("Это число больше 75?.(Еслибольше введите 1 если меньше введите 2)");
                    int bollee_75 = int.Parse(Console.ReadLine());
                          switch (bollee_75)
                          { case 1:
                                  //больше 75 (75-100)
                                     
                                  break;
                          case 2:
                                  //меньше 75 (51-75)
                                  break;
                          }
                    break;
                case 2:
                    //меньше 50 (1-49)
                     Console.WriteLine("Это число больше 25?.(Еслибольше введите 1 если меньше введите 2)");
                    int bollee_25 = int.Parse(Console.ReadLine());;
                    switch (bollee_25)
                    {
                        case 1:
                            //больше 25 (26-49)
                              Console.WriteLine("Это число больше 35?.(Еслибольше введите 1 если меньше введите 2)");
                    int bollee_35 = int.Parse(Console.ReadLine());;
                    switch (bollee_35)
                    { case 1:
                            //больше 35 (36-49)
                                      Console.WriteLine("Это число больше 42?.(Еслибольше введите 1 если меньше введите 2)");
                                        int bollee_42 = int.Parse(Console.ReadLine());;
                                        switch (bollee_35)
                                        { case 1:
                                                //больше 42 (43-49)

                                                break;
                                            case 2:

                                                //меньше 35 (1-35)
                                                break;
                    }
                            break;
                        case 2:

                            //меньше 35 (1-35)
                            break;
                    }

                            break;
                        case 2:
                           //меньше 25 (1-25)
                            break;
                    }
                    break;

            }

            Console.ReadKey();
        }
    }
}
