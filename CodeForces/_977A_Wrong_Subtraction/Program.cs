using System;

namespace _977A_Wrong_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            string[] divide = line.Split(' ');

            var n = int.Parse(divide[0]);
            var k = int.Parse(divide[1]);

            if (((n >= 2) && (n <= Math.Pow(10, 9))) && ((k >= 1) && (k <= 50)))
            {
                for (var i = 0; i < k; i++)
                {
                    if (n % 10 == 0)
                    {
                        n = n / 10;
                    }
                    else
                    {
                        n--;
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
}
