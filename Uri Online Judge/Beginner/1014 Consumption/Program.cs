using System;

namespace _1014_Consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(X/Y).ToString("0.000")} km/l");
        }
    }
}
