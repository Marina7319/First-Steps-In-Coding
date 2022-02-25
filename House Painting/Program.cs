using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете от конзолата  x, y, h 
            double x = double.Parse(Console.ReadLine());//6
            double y = double.Parse(Console.ReadLine());//10
            double h = double.Parse(Console.ReadLine());//5.2
            //1.x – височината на къщата – реално число в интервала[2...100]
            //2.y – дължината на страничната стена – реално число в интервала[2...100]
            //3.h – височината на триъгълната стена на прокрива – реално число в интервала[2...100]
            //стените зелена боя 
            //пкрива червена боя 
            //зелена боя 1л. за 3,4 кв.м
            //разход за зелена боя 1л за 4,3 кв.м
            //размер стени 
            //предна и задна стена са квадрати със страна х 
            //предна стена +врата 2м на 1,2м
            double frontWall = x * x - (2 * 1.2);//6x6-(2x1.2)=33.6
            //задна страна 
            double backWall = x * x;//6x6=36
            //странични стени са правоъгълници със страни х и у 
            //всяка страна има страничен прозорец с размери 1,5 м
            double wallWithWindows = 2 * (x * y - 1.5 * 1.5);//2x(6x10-1.5*1.5)=115.50
            //Размери на покрива 
            //2 правоъгълника със страни х и у 
            double roofSquare = 2 * (x * y);//2x(6x10)=120
            //2 равностранни триъгълника със страна х и височина h 
            double roofTriangle = 2 * (x * h / 2);//2x(6x5.2/2)=31.2
            //изчисляване всички страни и покрива 
            double SumRoof = roofTriangle + roofSquare;//31.2+120=151.2
            double SumWalls = wallWithWindows + backWall + frontWall;//115.5+36+33.6=185.1
            //изчисляване колко литра боя ще са необходими 
            double PaintWalls = SumWalls / 3.4;//185.1/3.4=54.44
            double PaintRoof = SumRoof / 4.3;//151.2/4.3=35.16
            //отпечатване на конзолата 
            Console.WriteLine($"{PaintWalls:f2}");
            Console.WriteLine($"{PaintRoof:f2}");
        }
    }
}
