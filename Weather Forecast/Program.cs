using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            //чете текст 
            string text = Console.ReadLine();
            //при въвеждане на sunny => "It's warm outside!"
            if (text == "sunny") {
                Console.WriteLine("It's warm outside!");
            } else {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
