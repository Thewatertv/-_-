﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1. Ввести число, и определить – чётное оно, или нет.");
            Console.WriteLine("Ввидите число");
            int rhiro = int.Parse(Console.ReadLine());



            if ((rhiro % 2) == 0)
                Console.WriteLine("Четное число");
            else
                Console.WriteLine("Ничетное число");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("2. Ввести три числа и найти наименьшее среди них.");
            Console.WriteLine("Ввидите  первое число");
            int pervoe_trb = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввидите  второе число");
            int pervoe_vtoroe = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввидите  третие число");
            int pervoe_tretue = int.Parse(Console.ReadLine());

            if (pervoe_trb > pervoe_vtoroe)
            {
                if (pervoe_trb > pervoe_tretue)
                    Console.WriteLine("Большие число первое");
                else
                    Console.WriteLine("Большие число третие");

            }
            else
            {
                if (pervoe_vtoroe > pervoe_tretue)
                    Console.WriteLine("Большие ВТОРОЕ третие");
                else
                    Console.WriteLine("Большие число третие");
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("3. Ввести число, и выяснить - положительное оно, отрицательное, или равно нулю?");

            Console.WriteLine("Ввидите   число");
            int tretur_zadaha = int.Parse(Console.ReadLine());
            if (tretur_zadaha == 0)
                Console.WriteLine("Число равно нулю");
            else
            {
                if (tretur_zadaha > 0)
                    Console.WriteLine("Число положительное");
                else
                    Console.WriteLine("Число отрицательное");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("4. Реализовать калькулятор. Вводятся 2 любых вещественных числа в переменные a и b. Необходимо вывести на экран меню с пунктами:");


            Console.WriteLine("Выбериет дейсвие");
            Console.WriteLine("1) a + b ");
            Console.WriteLine("2) a – b ");
            Console.WriteLine("3) a * b ");
            Console.WriteLine("4) a / b");
            Console.WriteLine("5) a % b");

            int deistvie = int.Parse(Console.ReadLine());

            Console.WriteLine("В ведите а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("В ведите b");
            double b = double.Parse(Console.ReadLine());
            switch (deistvie)
            {
                case 1:
                    Console.WriteLine("1) a + b");
                    a = a + b;
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine("2) a – b");
                    a = a - b;
                    Console.WriteLine(a);
                    break;
                case 3:
                    Console.WriteLine("3) a * b");
                    a = a * b;
                    Console.WriteLine(a);
                    break;
                case 4:
                    Console.WriteLine("4) a / b");
                    if (a == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                    {
                        if (b == 0)
                            Console.WriteLine("На ноль делить нельзя");
                        else
                            a = a / b;
                        Console.WriteLine(a);
                    }




                    break;
                case 5:
                    Console.WriteLine("5) a % b");
                    a = a % b;
                    Console.WriteLine(a);
                    break;
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("5. Ввести с клавиатуры символ. Определить, чем он является: цифрой, буквой или знаком пунктуации.");

            var hiclo_cimvol_zifra = Console.ReadKey().KeyChar;
            if (char.IsLetter(hiclo_cimvol_zifra))
                Console.WriteLine(" - Это буква");
            else if (char.IsNumber(hiclo_cimvol_zifra))
                Console.WriteLine(" - Это цифра");
            else Console.WriteLine(" - Это знак пунктуации");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("6. Ввести с клавиатуры число и проверить, принадлежит ли это число диапазону от N до M (включительно).");


            Console.WriteLine("Введите число");
           int huclo_v_duapazon = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите верхнюю границу диапазона");
            int Verhia = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите нижнюю границу диапазона");
            int hiznua = int.Parse(Console.ReadLine());
            if (huclo_v_duapazon >= Verhia && huclo_v_duapazon <= hiznua)
                Console.WriteLine("Данное число входит в диапазон");
            else Console.WriteLine("Данное число не входит в диапазон");



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("7. Написать программу для проверки кратности числа X числу Y (оба числа вводятся с клавиатуры).");
            Console.WriteLine("Введите X");
            Double vvedite_x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y");
            Double vvedite_y = Double.Parse(Console.ReadLine());
            int nulll; nulll = 0;

            if (vvedite_x % vvedite_y == nulll)
                Console.WriteLine("Число кратно");
            else Console.WriteLine("Число не кратно");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("8. Ввести число и определить кратно ли оно 3, 5, и 7 одновременно.");

            Console.WriteLine("Введите число");
            Double vvedite_hzero = Double.Parse(Console.ReadLine());

            ;

            if (vvedite_hzero % 3 == nulll)
            {

                if (vvedite_hzero % 5 == nulll)
                {
                    if (vvedite_hzero % 7 == nulll)
                        Console.WriteLine("Число кратно");
                    else Console.WriteLine("Число не кратно");

                }
                else Console.WriteLine("Число не кратно");

            }
            else Console.WriteLine("Число не кратно");

            int midel_hero; midel_hero = 0;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("9. Показать модуль введённого числа.");
            Console.WriteLine("Введите число");
            int hero_model = int.Parse(Console.ReadLine());

            midel_hero = Math.Abs(hero_model);


            Console.WriteLine("Модуль" + midel_hero);

            Console.WriteLine("");
            Console.WriteLine("");
            int hero_ne_bolee__1, hero_ne_bolee__2 ,hero_ne_bolee__3, hero_ne_bolee__4;
            Console.WriteLine("10.  Вводится целое число (не более 4 разрядов!). Определить количество цифр в нём.");
            Console.WriteLine("Ведите число (не более 4 разрядов!)");
            int hero_ne_bolee_4 = int.Parse(Console.ReadLine());

            hero_ne_bolee__2 = hero_ne_bolee_4 % 1000;
            hero_ne_bolee__1 = (hero_ne_bolee_4 - hero_ne_bolee__2) / 1000;
            hero_ne_bolee__3 = hero_ne_bolee__2 % 100;
            hero_ne_bolee__2 = (hero_ne_bolee__2 - hero_ne_bolee__3) / 100;
            hero_ne_bolee__4 = hero_ne_bolee__3 / 10;
            hero_ne_bolee__3 = (hero_ne_bolee__3 - hero_ne_bolee__4) / 10;

            if (hero_ne_bolee__1 == 0)
                    {

                if (hero_ne_bolee__2 == 0)
                    {
                    if (hero_ne_bolee__3 == 0)
                    {
                        if (hero_ne_bolee__4 == 0)
                    { }

            else 
            Console.WriteLine("1 значное");
                    }

            else 
            Console.WriteLine("2 значное");
                }

            else 
            Console.WriteLine("3 значное");
            }

            else 
            Console.WriteLine("4 значное");






            Console.WriteLine("11. Ввести с клавиатуры пятизначное число и определить, является ли оно палиндромом (т.е. одинаково читается в обоих направлениях - например, 12321 будет палиндромом, а 12345 – не палиндром).");
            int number1, number2, number3, number4, number5;
            Console.WriteLine("Введите пятизначное число");
            int number = int.Parse(Console.ReadLine());
            number2 = number % 10000;
            number1 = (number - number2) / 10000;
            number3 = number2 % 1000;
            number2 = (number2 - number3) / 1000;
            number4 = number3 % 100;
            number3 = (number3 - number4) / 100;
            number5 = number4 % 10;
            number4 = (number4 - number5) / 10;


           

          

            if (number1 == number5 && number2 == number4)
                Console.WriteLine("Это число - палиндром");
            else Console.WriteLine("Это число - не палиндром");

            Console.WriteLine("11. Ввести с клавиатуры пятизначное число и определить, является ли оно палиндромом (т.е. одинаково читается в обоих направлениях - например, 12321 будет палиндромом, а 12345 – не палиндром).");

      
            Console.WriteLine("Введите координату x верхнего левого угла");
            int  x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y верхнего левого угла");
            int  y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x нижнего правого угла");
            int  x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y нижнего правого угла");
            int  y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X точки");
            int  x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки");
            int  y = int.Parse(Console.ReadLine());

            if (x >= x2 && y >= y2 & x <= x3 && y <= y3)
                Console.WriteLine("Эта точка принадлежит прямоугольнику");
            else Console.WriteLine("Эта точка не принадлежит прямоугольнику");
            Console.ReadKey(true);



        }
    }
}
