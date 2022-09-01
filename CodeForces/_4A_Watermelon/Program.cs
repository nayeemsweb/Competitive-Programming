using System;

namespace _4A_Watermelon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());

            //Checking Logic
		if (w == 2)
            {
                Console.WriteLine("No");
            }
            else if (w % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
