using System;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 1534236469;
            var reverse = new Solution();
            var b = reverse.Reverse(x);
            Console.WriteLine(b);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

        }

        public class Solution
        {
            public int Reverse(int x)
            {
                var result = 0;

                while(x != 0)
                {
                    var remainder = x % 10;                    

                    var newResult = (result * 10) + remainder;                    

                    if ((newResult - remainder) / 10 != result)
                        return 0;

                    x /= 10;
                    result = newResult;                    
                }    
                
                return result;
            }
        }
    }
}
