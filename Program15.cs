using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15. Необходимо срочно к Новому году  нарисовать ёлочку. С клавиатуры вводится количество ярусов, и высота каждого яруса ёлочки. Например, на картинке 4 яруса, высота каждого яруса – 5 символов.");

            Console.WriteLine("Введите количесво ярусов");
            int kollvo = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту ярусв ");
            int vusota = int.Parse(Console.ReadLine());
           int i=1;
           int ha = 10;
           int m = 0;
           int wqe = 14;
            int asd=kollvo+vusota;
            int j = 0;
            int asdf = asd / 2;
            for (; i <= vusota; i++)
            {

                for (int i3 = 1; i3 <= kollvo; i3++)
                {
                    for (int i5 = 1; i5 <= ha; i5++)
                    { Console.Write(" "); }
                    for (int i1 = 1; i1 <= asd; i1++)
                    {
                        


                            if (i1 <= asdf + j && i1 >= asdf - j)
                                Console.Write("<>");
                            else
                                Console.Write("  ");

                        //  Console.Write(i1 + "== "+asdf +"   "+ j);
                        // Console.Write(asd);



                    }
                    Console.WriteLine("  ");

                    j = j + 1;
                    
                }
                
                asdf = asdf + 1;
                j = 1+m;
                asd = asd + 1;
                m = m + 1;
                ha = ha - 1;
                if (asd <= wqe)
                {
                    asd = asd + 1;
                    wqe = wqe + 1;
                }
                


            }


            for (int i7 = 1; i7 <= (asdf - kollvo/2)-i7; i7++) 
            {
                for (int i8 = 1; i8 <= asdf +asd/2; i8++)
                { Console.Write(" ");}


            if (i7 == asdf + j)
                Console.Write("");
            else
                Console.Write(" <><><> ");
            Console.WriteLine(" ");
            }

           
            Console.ReadKey();
        }
    }
}
