using System;

namespace _1006_Average_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = Convert.ToDouble(Console.ReadLine());
            var B = Convert.ToDouble(Console.ReadLine());
            var C = Convert.ToDouble(Console.ReadLine());

            var avg = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);
            Console.WriteLine($"MEDIA = {avg.ToString("0.0")}");
        }
    }
}
