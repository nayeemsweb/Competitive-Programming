using System;
using System.Linq;

namespace _236A_Boy_or_Girl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var distinctLetters = name.Distinct();
            var noOfLetters = 0;

            foreach (var letter in distinctLetters) noOfLetters++;

            if (noOfLetters % 2 == 0) Console.WriteLine("CHAT WITH HER!");
            else if (noOfLetters % 2 != 0) Console.WriteLine("IGNORE HIM!");
        }
    }
}
