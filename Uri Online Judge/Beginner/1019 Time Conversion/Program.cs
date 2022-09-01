using System;

namespace _1019_Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var hour = 0;
            var min = 0; 
            var sec = 0;

            hour = N / 3600;
            N = N % 3600;
            min = N / 60;
            sec = N % 60;
            Console.WriteLine($"{hour}:{min}:{sec}");
        }

        /*
         if(N >= 3600)
            {
                Console.Write($"{N/3600}:");
                N = N % 3600;
                
                if(N <= 3599 && N >= 60)
                {
                    Console.Write($"{N/60}:");
                    N = N % 60;

                    if(N <= 60)
                    {
                        Console.Write($"{N}");
                    }
                }                
            }
            else if (N <= 3599 && N >= 60)
            {
                Console.Write($"{0}:{N/60}:");
                N = N % 60;

                if (N <= 60)
                {
                    Console.Write($"{N}");
                }
            }
            else if (N <= 60)
            {
                Console.Write($"{0}:{0}:{N}");
            }
         
         */
    }
}
