using System;

namespace _1017_Fuel_Spent
{
    class Program
    {
        static void Main(string[] args)
        {
            var spentTime = int.Parse(Console.ReadLine());
            var avgSpeed = int.Parse(Console.ReadLine());

            var neededFuel = (spentTime * avgSpeed) / 12.0;
            Console.WriteLine(neededFuel.ToString("0.000"));
        }
    }
}
