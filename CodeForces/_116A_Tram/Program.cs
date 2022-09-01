using System;

namespace _116A_Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tramStops = int.Parse(Console.ReadLine());
            var enterToTram = new int[tramStops];
            var getOutFromTram = new int[tramStops];

            var minCapacity = 0;
            var capacity = 0;

            for (var i = 0; i < tramStops; i++)
            {
                var stoppage = Console.ReadLine().Split(' ');

                getOutFromTram[i] = int.Parse(stoppage[0]);
                enterToTram[i] = int.Parse(stoppage[1]);

                capacity = Math.Abs(capacity - getOutFromTram[i]) + enterToTram[i];
                if (capacity > minCapacity) minCapacity = capacity;
            }
            Console.WriteLine(minCapacity);
        }
    }
}
