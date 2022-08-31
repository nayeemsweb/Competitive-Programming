using System;
using System.Text;

namespace _118A_String_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToLower();

            var newString = "";
            var stringBuilder = new StringBuilder(newString);

            for (var i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != 'a' && inputString[i] != 'e' && inputString[i] != 'i' && inputString[i] != 'o' && inputString[i] != 'u' && inputString[i] != 'y')
                {
                    stringBuilder.Append($".{inputString[i]}");
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
