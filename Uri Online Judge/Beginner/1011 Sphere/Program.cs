using System;

namespace _1011_Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = double.Parse(Console.ReadLine());

            Console.WriteLine($"VOLUME = {((4.0 / 3) * 3.14159 * (Math.Pow(R, 3))).ToString("0.000")}");
        }
    }
}
