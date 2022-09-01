using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse String

            //Write a function that reverses a string.The input string is given as an array of characters s.
            //You must do this by modifying the input array in-place with O(1) extra memory.
            //https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/

            var array = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var solution = new Solution();
            solution.ReverseString(array);

        }

        public class Solution
        {
            public void ReverseString(char[] s)
            {
                var start = 0;
                var end = s.Length - 1;

                while (start <= end)
                {
                    var temp = s[start];
                    s[start] = s[end];
                    s[end] = temp;

                    start++;
                    end--;
                }
            }
        }
    }
}
