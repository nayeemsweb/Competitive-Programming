using System;

namespace _1220A_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var line = Console.ReadLine();

            string[] givenChars = new string[line.Length];


            for (var i = 0; i < line.Length; i++)
            {
                givenChars[i] = line.Substring(i, 1);
            }

            var binaryOne = 0;
            var binaryZero = 0;

            for (var i = 0; i < line.Length; i++)
            {
                if (givenChars[i] == "n")
                {
                    binaryOne++;
                }
                else if (givenChars[i] == "z")
                {
                    binaryZero++;
                }
            }

            for (var i = 0; i < binaryOne; i++)
            {
                Console.Write($"1 ");
            }
            for (var i = 0; i < binaryZero; i++)
            {
                Console.Write($"0 ");
            }
        }
    }
}
