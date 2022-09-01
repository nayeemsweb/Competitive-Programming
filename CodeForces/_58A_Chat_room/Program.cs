using System;

namespace _58A_Chat_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine().ToLower();

            var targetString = "hello";
            var targetStringCurrentIndex = 0;
            var totalLetterAchieved = 0;

            for (var i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == targetString[targetStringCurrentIndex])
                {
                    totalLetterAchieved++;
                    targetStringCurrentIndex++;

                    if (totalLetterAchieved == 5) break;
                }
            }

            if (totalLetterAchieved >= 5) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
