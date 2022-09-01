using System;

namespace _339A_Helpful_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            var size = (inputString.Length / 2) + 1;

            var splittedString = inputString.Split('+');
            var inputArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                var a = int.Parse(splittedString[i]);
                inputArray[i] = a;
            }

            for (int i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        var temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }

            for (var i = size - 1; i >= 0; i--)
            {
                if (i != 0 || i == 0) Console.Write(inputArray[i]);
                if (i != 0) Console.Write("+");
            }
        }
    }
}
