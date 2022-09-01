using System;

namespace _282A_Bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noOfStatements = int.Parse(Console.ReadLine());
            var finalValue = 0;

            for (var i = 0; i < noOfStatements; i++)
            {
                var instructions = Console.ReadLine();
                if (instructions == "X++" || instructions == "++X") finalValue++;
                if (instructions == "X--" || instructions == "--X") finalValue--;
            }

            Console.WriteLine(finalValue);
        }
    }
}
