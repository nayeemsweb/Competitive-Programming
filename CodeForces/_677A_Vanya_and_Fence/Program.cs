//677A Vanya and Fence - Nayeem Rahman

using System;

namespace _677A_Vanya_and_Fence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine().Split(' ');

            var numOfPeople = int.Parse(userInput[0]);
            var heightOfFence = int.Parse(userInput[1]);

            var heights = Console.ReadLine().Split(' ');

            var minWidth = 0;
            for (var i = 0; i < numOfPeople; i++)
            {
                if (int.Parse(heights[i]) <= heightOfFence)
                    minWidth += 1;
                else
                    minWidth += 2;
            }
            Console.WriteLine(minWidth);
        }
    }
}
