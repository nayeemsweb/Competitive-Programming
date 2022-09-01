using System;

namespace _69A_Young_Physicist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            var cordinateArray = new int[testCases, 3];
            var coordinateX = 0;
            var coordinateY = 0;
            var coordinateZ = 0;

            for (var i = 0; i < testCases; i++)
            {
                var data = Console.ReadLine().Split(' ');

                coordinateX += int.Parse(data[0]);
                coordinateY += int.Parse(data[1]);
                coordinateZ += int.Parse(data[2]);
            }

            if (coordinateX == 0 && coordinateY == 0 && coordinateZ == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
