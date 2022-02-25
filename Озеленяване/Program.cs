using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());
            double sum = yard * 7.61;
            double discount = sum * 0.18;
            double total = sum - discount;
            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
