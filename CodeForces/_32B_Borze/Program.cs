using System;
using System.Text;

namespace _32B_Borze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToCharArray();
            var numberString = "";
            var stringBuilder = new StringBuilder(numberString);

            for(var i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] == '.') stringBuilder.Append('0');
                else if(inputString[i] == '-')
                {
                    if (inputString[i + 1] == '.') stringBuilder.Append('1');
                    else if (inputString[i + 1] == '-') stringBuilder.Append('2');
                    i++;
                }
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
