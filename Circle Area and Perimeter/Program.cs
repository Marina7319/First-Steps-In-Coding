using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            //четене на цяло число радиус r 
            double radius = double.Parse(Console.ReadLine());//3
            //пресмятане на лице и периметър на кръг
            double area = Math.PI * radius * radius;//3.14x3x3=9.42x3=.28.26
            double perimeter = 2 * Math.PI * radius;//2x3.14x3=6.28x3=18.84

            //отпечатване на резултата  във формат "<calculated area>" "<calculated parameter>".
            //Форматирайте изходните данни до втория знак след десетичната запетая 

            Console.WriteLine($"{area:f2}");//28.26
            Console.WriteLine($"{perimeter:f2}");//18.84
        }
    }
}
