using System;

namespace _71A_Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Storing User Inputs

            int noOfWords = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[noOfWords];
            int i;
            for (i = 0; i < noOfWords; i++)
            {
                array[i] = Console.ReadLine();
            }

            #endregion

            #region Printing 

            for (i = 0; i < noOfWords; i++)
            {
                if (array[i].Length > 10)
                {
                    Console.WriteLine($"{array[i].Substring(0, 1)}{(array[i].Length) - 2}{array[i].Remove(0, array[i].Length - 1)}");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            #endregion
        }
    }
}
