using System;

namespace _1020_Age_in_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var years = 0;
            var months = 0;
            var days = 0;

            years = input / 365;
            input = input % 365;

            months = input / 30;

            days = input % 30;

            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");
        }
    }
}
