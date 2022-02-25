using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int DogFood = int.Parse(Console.ReadLine());//5
            int CatFood = int.Parse(Console.ReadLine());//4
            double total = DogFood * 2.50 + CatFood * 4;//5x2.50+4x4=12.5+16=28.5
            Console.WriteLine($"{total} lv.");//28.5 lv.
        }
    }
}
