using System;

namespace room
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            if (!(3 <= h))
            {
                double h2 = double.Parse(Console.ReadLine());
            }
            if (!(w <= 100))
            {
                double w2 = double.Parse(Console.ReadLine());
            }
            //изчисляване размерите на цялата зала 
            double hight = h * 100;
            double width = w * 100;

            //изчисляване лявата част на залата
            double widthL = width / 2;
            double sumW =Math.Floor( widthL / 70);
            double sumH = Math.Floor(hight / 120);
            double sumL = sumW * sumH;
            Console.WriteLine(sumL);
            //изчисляване дясната част на залата
            double widthR = width / 2 - 100;
            double sumWR = Math.Floor(widthR / 70);
            double sumHR = Math.Floor(hight / 120) ;
            double sumR = sumWR * sumHR;

            Console.WriteLine(sumR);



            //изчисляване общия брой на местата

            double total = sumR + sumL - 3;
            Console.WriteLine(total);
            //отпечатване на резултата 
        }
    }
}

