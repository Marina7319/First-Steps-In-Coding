using System;

namespace _05._TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {                   
                double h = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                if (!(3 <= h))
                {
                    double h2 = double.Parse(Console.ReadLine());
                }
                if (!(w <= 100))
                {
                    double w2 = double.Parse(Console.ReadLine());
                }
                double width = w * 100 - 100;
                double hight = h * 100;
                double tables = Math.Floor(width / 70);
                double tablesH = Math.Floor(hight / 120);
                double total = tables * tablesH;
                Console.WriteLine(total - 3);
            }
        }
    }
