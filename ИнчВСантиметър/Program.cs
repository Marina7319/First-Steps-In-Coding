using System;

namespace ИнчВСантиметър
{
    class Program
    {
        static void Main(string[] args)
        {
            double santimetar = double.Parse(Console.ReadLine());//5
            double InchToSantimeter = santimetar * 2.54;//5x2.54=11.08
            Console.WriteLine(InchToSantimeter);//12.08
        }
    }
}
