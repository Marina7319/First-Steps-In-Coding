using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());//20
            double h = double.Parse(Console.ReadLine());//30
            double formula = a * h / 2;//20x30/2=300
            Console.WriteLine($"{formula:f2}");//300.00
        }
    }
}
