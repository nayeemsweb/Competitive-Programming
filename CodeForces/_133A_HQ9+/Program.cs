using System;

namespace _133A_HQ9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();

            var count = 0;
            for (var i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'H' || userInput[i] == 'Q' || userInput[i] == '9')
                {
                    count++; break;
                }
            }

            if (count > 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
