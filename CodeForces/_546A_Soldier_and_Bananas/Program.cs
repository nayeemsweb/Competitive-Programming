using System;

namespace _546A_Soldier_and_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().Split(' ');

            var price = 0;

            var k = int.Parse(inputString[0]);
            var n = int.Parse(inputString[1]);
            var w = int.Parse(inputString[2]);

            for (var i = 1; i <= w; i++)
            {
                price += i;
            }

            var borrowedMoney = (price * k) - n;

            if (borrowedMoney < 0) Console.WriteLine("0");
            else Console.WriteLine(borrowedMoney);
        }
    }
}
