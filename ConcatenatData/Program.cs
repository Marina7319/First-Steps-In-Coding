using System;

namespace ConcatenatData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();//Nikolay
            string lastname = Console.ReadLine();//Danev
            int age = int.Parse(Console.ReadLine());//20
            string town = Console.ReadLine();//Pernik
            Console.WriteLine($"You are {firstname} {lastname}, a {age}-years old person from {town}.");
            //You are Nikolay Danev, a 20-years old person from Pernik.
        }
    }
}
