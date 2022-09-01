using System;

namespace _1037_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Convert.ToDouble(Console.ReadLine());

            if(input >= 0 && input <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (input > 25.0 && input <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (input > 50.0 && input <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (input > 75.0 && input <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
