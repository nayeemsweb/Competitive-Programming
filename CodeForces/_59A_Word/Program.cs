using System;

namespace _59A_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();

            var upperCaseCounter = 0;
            var lowerCaseCounter = 0;

            for (var i = 0; i < userInput.Length; i++)
            {
                if (Char.IsUpper(userInput[i])) upperCaseCounter++;
                if (Char.IsLower(userInput[i])) lowerCaseCounter++;
            }

            if (upperCaseCounter > lowerCaseCounter) Console.WriteLine(userInput.ToUpper());
            else Console.WriteLine(userInput.ToLower());
        }
    }
}
