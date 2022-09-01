using System;

namespace _266A_Stones_on_the_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noOfStones = int.Parse(Console.ReadLine());
            var stoneColors = Console.ReadLine();

            var stonePair = 0;

            for (var i = 0; i < noOfStones - 1; i++)
            {
                if (stoneColors[i] == stoneColors[i + 1]) stonePair++;
            }
            Console.WriteLine(stonePair);
        }
    }
}
