using System;

namespace _112A_Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstString = Console.ReadLine().ToLower();
            var secondString = Console.ReadLine().ToLower();

            if (firstString == secondString) Console.WriteLine("0");
            else
            {
                for (var i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] > secondString[i])
                    {
                        Console.WriteLine("1");
                        break;
                    }
                    if ((firstString[i] < secondString[i]))
                    {
                        Console.WriteLine("-1");
                        break;
                    }
                }
            }
        }
    }
}
