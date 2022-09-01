using System;

namespace _271A_Beautiful_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());

            while (true)
            {
                year++;

                var a = year / 1000;
                var b = year / 100 % 10;
                var c = year / 10 % 10;
                var d = year % 10;

                if(a != b && a!=c && a!=d && b!=c && b!=d && c != d)
                {
                    Console.WriteLine(year);
                    break;
                }
            }
        }
    }
}
