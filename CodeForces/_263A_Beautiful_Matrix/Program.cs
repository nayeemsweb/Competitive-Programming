using System;

namespace _263A_Beautiful_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[5, 5];

            #region User Inputs
            for (var i = 0; i < 5; i++)
            {
                var colInput = Console.ReadLine();
                var delimiter = colInput.Split(' ');

                for (var j = 0; j < 5; j++)
                {
                    matrix[i, j] = Convert.ToInt32(delimiter[j]);
                }
            }
            #endregion

            #region Finding shortest path
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
                    }
                }
            }
            #endregion
        }
    }
}
