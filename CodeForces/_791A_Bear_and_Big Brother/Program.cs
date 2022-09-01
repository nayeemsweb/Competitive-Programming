using System;

namespace _791A_Bear_and_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ageString = Console.ReadLine();
            string[] divide = ageString.Split(' ');

            int[] a = new int[] { int.Parse(divide[0]) };
            int[] b = new int[] { int.Parse(divide[1]) };

            var countYear = 0;

            while (a[0] <= b[0])
            {
                a[0] *= 3;
                b[0] *= 2;
                countYear++;
            }

            Console.WriteLine(countYear);
        }
    }
}
