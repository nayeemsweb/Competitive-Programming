using System;

namespace _281A_Word_Capitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            if (inputString.Length <= 1000 && inputString != null)
            {
                var firstPart = inputString.Substring(0, 1);
                firstPart = firstPart.ToUpper();

                var secondPart = inputString.Substring(1, inputString.Length - 1);
                //secondPart = secondPart.ToLower();

                Console.WriteLine($"{firstPart}{secondPart}");
            }
        }
    }
}
