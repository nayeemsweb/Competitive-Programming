using System;

namespace _1005_Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = Convert.ToDouble(Console.ReadLine());
            var B = Convert.ToDouble(Console.ReadLine());

            var avg = ((A * 3.5) + (B * 7.5))/ (3.5 + 7.5);
            Console.WriteLine($"MEDIA = {avg.ToString("0.00000")}");
        }
    }
}
