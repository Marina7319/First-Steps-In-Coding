using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double fishOnePrice = double.Parse(Console.ReadLine());
            double fishTwoPrice = double.Parse(Console.ReadLine());
            double fishOneKilos = double.Parse(Console.ReadLine());
            double fishTwoKilos = double.Parse(Console.ReadLine());
            double FishTreeKilos = double.Parse(Console.ReadLine());
            double fishTreePrice = fishOnePrice + fishOnePrice * 0.6;
            double fishFourPrice = fishTwoPrice + fishTwoPrice * 0.8;
            double fishFiveSum = FishTreeKilos * 7.50;
            double Sum = fishFiveSum + (fishOneKilos * fishTreePrice) + (fishFourPrice * fishTwoKilos);
            Console.WriteLine($"{Sum:f2}");
        }
    }
}
