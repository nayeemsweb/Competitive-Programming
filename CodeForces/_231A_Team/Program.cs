using System;

namespace _231A_Team
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numOfProblems = int.Parse(Console.ReadLine());
            var willImplement = 0;

            for (int i = 0; i < numOfProblems; i++)
            {
                var ensuredBy = Console.ReadLine().Split(' ');
                var sum = int.Parse(ensuredBy[0]) + int.Parse(ensuredBy[1]) + int.Parse(ensuredBy[2]);

                if(sum >= 2)
                {
                    willImplement++;
                }
            }

            Console.WriteLine(willImplement);
        }
    }
}
