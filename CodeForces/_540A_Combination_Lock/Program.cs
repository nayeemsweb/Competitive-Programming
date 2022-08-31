using System;

namespace _540A_Combination_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var originalState = Console.ReadLine();
            var combination = Console.ReadLine();

            int[] originalStateArray = new int[n];
            int[] combinationArray = new int[n];
            var noOfMoves = 0;


            if (n >= 1 && n <= 1000 && originalState.Length == n && combination.Length == n)
            {
                for (var i = 0; i < n; i++)
                {
                    //Putting the inputs in the arrays
                    originalStateArray[i] = int.Parse(originalState.Substring(i, 1));
                    combinationArray[i] = int.Parse(combination.Substring(i, 1));

                    //Counting the number of moves 
                    if (originalStateArray[i] > combinationArray[i])
                    {
                        var temp = (originalStateArray[i] - combinationArray[i]);
                        if (temp > 5)
                        {
                            noOfMoves += ((combinationArray[i] + 10) - originalStateArray[i]);
                        }
                        else
                        {
                            noOfMoves += temp;
                        }
                    }
                    else if (originalStateArray[i] < combinationArray[i])
                    {
                        var temp = combinationArray[i] - originalStateArray[i];
                        if (temp > 5)
                        {
                            noOfMoves += ((originalStateArray[i] + 10) - combinationArray[i]);
                        }
                        else
                        {
                            noOfMoves += temp;
                        }
                    }
                }
            }

            Console.WriteLine(noOfMoves);
        }
    }
}
