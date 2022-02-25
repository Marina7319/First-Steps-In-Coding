using System;

namespace CToF
{
    class Program
    {
        static void Main(string[] args)
        {
          // C = 32 °F;
            double C = double.Parse(Console.ReadLine());//25
            double F = (C * 9 / 5) +32;//(25x9/5)+32=77
            Console.WriteLine($"{F:f2}");//77.00
        }
    }
}
