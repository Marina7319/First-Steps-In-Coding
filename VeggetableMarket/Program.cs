using System;

namespace VeggetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());//0.194
            double m = double.Parse(Console.ReadLine());//19.4
            double kiloVeggetables = double.Parse(Console.ReadLine());//10
            double kiloFruits = double.Parse(Console.ReadLine());//10
            double veggies = n * kiloVeggetables;//0.194x10=1.94
            Console.WriteLine(veggies);
            double fruits = m * kiloFruits;//19.4x10=194
            Console.WriteLine(fruits);
            double result = veggies + fruits;//194+1.97=195.94
            Console.WriteLine(result);
            double euro = result / 1.94;//195.94/1.94=101.00
            Console.WriteLine($"{euro:f2}");//101.00
        }
    }
}
