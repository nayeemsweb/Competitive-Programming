using System;

namespace _200B_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var inputString = Console.ReadLine();
            string[] divide = inputString.Split(' ');

            int[] bottles = new int[size];

            if (size >= 1 & size <= 100)
            {
                for (var i = 0; i < size; i++)
                {
                    bottles[i] = int.Parse(divide[i]);
                }

                var sum = 0.0;
                for (var i = 0; i < size; i++)
                {
                    sum += bottles[i];
                }

                Console.WriteLine($"{(sum / size).ToString("0.000000000000")}");
            }
        }
    }
}
