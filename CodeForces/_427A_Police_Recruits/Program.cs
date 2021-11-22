using System;

namespace _427A_Police_Recruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var events = int.Parse(Console.ReadLine());
            var inputString = Console.ReadLine();
            int[] incidents = new int[events];

            string[] divide = inputString.Split(' ');

            var crime = 0;
            var police = 0;
            for (var i = 0; i < events; i++)
            {
                incidents[i] = int.Parse(divide[i]);

                if (incidents[i] >= 1 && incidents[i] <= 10)
                {
                    police = police + incidents[i];
                }
                else
                {
                    if (incidents[i] == -1 && police == 0)
                    {
                        crime++;
                    }
                    else if (incidents[i] == -1 && police != 0)
                    {
                        police--;
                    }
                }
            }

            Console.WriteLine(crime);
        }
    }
}
