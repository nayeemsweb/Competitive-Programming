using System;
using System.Collections.Generic;

namespace _1_Two_Number_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Two Number Sum            

            var array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            var result = TwoNumberSum(array, 10);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }

        #region Solution - 1
        // Time = O(N^2)

        //public static int[] TwoNumberSum(int[] array, int targetSum)
        //{
        //    for(var i = 0; i < array.Length - 1; i++)
        //    {
        //        var firstNum = array[i];
        //        for (var j = i + 1; j < array.Length; j++)
        //        {
        //            var secondNum = array[j];
        //            if(firstNum + secondNum == targetSum)
        //            {
        //                return new int[] { firstNum, secondNum };
        //            }
        //        }
        //    }
        //    return new int[0];
        //}
        #endregion

        #region Solution - 2
        // Time = O(N)
        // Space = O(N)

        //public static int[] TwoNumberSum(int[] array, int targetSum)
        //{
        //    var nums = new HashSet<int>();

        //    foreach(var num in nums)
        //    {
        //        var potentialMatch = targetSum - num;
        //        if (nums.Contains(potentialMatch))
        //        {
        //            return new int[] {potentialMatch, num};
        //        }
        //        else
        //        {
        //            nums.Add(num);
        //        }
        //    }
        //    return new int[0];
        //}
        #endregion

        #region Solution - 3
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Time = O(nlog(n))
            // Space = O(1)

            Array.Sort(array);
            var start = 0;
            var end = array.Length - 1;

            while (start < end)
            {
                var currentSum = array[start] + array[end];

                if (currentSum == targetSum)
                {
                    return new int[] { array[start], array[end] };
                }
                else if (currentSum > targetSum)
                {
                    end--;
                }                    
                else if(currentSum < targetSum)
                {
                    start++;
                }                    
            }
            return new int[0];
        }
        #endregion
    }
}
