using System;

namespace _617A_Elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friendsHouseDistance = int.Parse(Console.ReadLine());

            if (friendsHouseDistance % 5 == 0) Console.WriteLine(friendsHouseDistance / 5);
            else Console.WriteLine((friendsHouseDistance / 5) + 1);
        }
    }
}
