using System;

namespace _96A_Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;

            for (var i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '1')
                {
                    counter1++;
                    counter2 = 0;
                }
                else
                {
                    counter2++;
                    counter1 = 0;
                }

                if (counter1 == 7 || counter2 == 7) counter3 = 1;
            }
            if (counter3 == 1) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
