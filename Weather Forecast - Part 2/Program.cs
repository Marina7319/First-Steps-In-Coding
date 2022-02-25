using System;

namespace Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //четене на число градуси
            double celsius = double.Parse(Console.ReadLine());
            //изчисляване какво е времето 
            if (26 <= celsius && celsius <= 35)
            {
                Console.WriteLine("Hot");
                // 26.00 - 35.00   Hot
                //отпечатване на конзолата
            }
            else if (20.1 <= celsius && 25.9 >= celsius)
            {
                Console.WriteLine("Warm");
                //20.1 - 25.9 Warm
                //отпечатване на конзолата
            }
            else if (15.00 <= celsius && 20.00 >= celsius)
            {
                Console.WriteLine("Mild");
                //15.00 - 20.00   Mild
                //отпечатване на конзолата
            }
            else if (12.00 <= celsius && 14.9 >= celsius)
            {
                Console.WriteLine("Cool");
                //12.00 - 14.9    Cool
                //отпечатване на конзолата
            }
            else if (5.00 <= celsius && 11.9 >= celsius)
            {
                Console.WriteLine("Cold");
                //5.00 - 11.9 Cold
                //отпечатване на конзолата
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
