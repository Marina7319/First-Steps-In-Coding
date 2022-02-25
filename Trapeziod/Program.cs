using System;

namespace Trapeziod
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());//8
            double b = double.Parse(Console.ReadLine());//13
            double h = double.Parse(Console.ReadLine());//7
            double formula = (a + b) * h / 2;//(8+13)x7/2=73.5
            Console.WriteLine($"{formula:f2}");//73.50
        }
    }
}
