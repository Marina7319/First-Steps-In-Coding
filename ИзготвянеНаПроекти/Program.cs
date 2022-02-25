using System;

namespace ИзготвянеНаПроекти
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();//George
            int projects = int.Parse(Console.ReadLine());//4
            int hours = projects * 3;//4x3=12
            Console.WriteLine($"The architect {architect} will need {hours} hours to complete {projects} project/s.");
            //The architect George will need 12 hours to complete 4 project/s.
        }
    }
}
