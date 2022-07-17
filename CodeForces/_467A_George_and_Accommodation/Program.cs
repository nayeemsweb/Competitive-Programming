//467A George and Accommodation - Nayeem Rahman

using System;

namespace _467A_George_and_Accommodation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numOfRooms = int.Parse(Console.ReadLine());
            var numOfVacantRooms = 0;

            for (var i = 0; i < numOfRooms; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var seats = int.Parse(input[1]) - int.Parse(input[0]);

                if ((int.Parse(input[0]) < int.Parse(input[1])) && seats >= 2)
                    numOfVacantRooms++;
            }
            Console.WriteLine(numOfVacantRooms);
        }
    }
}
