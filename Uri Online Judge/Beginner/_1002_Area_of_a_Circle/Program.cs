using System;

namespace _1002_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = double.Parse(Console.ReadLine());
            Console.WriteLine($"A={(3.14159 * Math.Pow(R, 2)).ToString("0.0000")}");
        }
    }
}
