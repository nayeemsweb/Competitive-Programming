using System;

namespace _1038_Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] divide = input.Split(' ');
            int[] X = new int[divide.Length];
            int[] Y = new int[divide.Length];

            for(var i=0; i<divide.Length; i++)
            {
                X[i] = int.Parse(divide[0]);
                Y[i] = int.Parse(divide[1]);
            }

            if (X[0] == 1)
            {
                Console.WriteLine($"Total: R$ {(Y[0] * 4.00).ToString("0.00")}");
            }
            else if (X[0] == 2)
            {
                Console.WriteLine($"Total: R$ {(Y[0] * 4.50).ToString("0.00")}");
            }
            else if (X[0] == 3)
            {
                Console.WriteLine($"Total: R$ {(Y[0] * 5.00).ToString("0.00")}");
            }
            else if (X[0] == 4)
            {
                Console.WriteLine($"Total: R$ {(Y[0] * 2.00).ToString("0.00")}");
            }
            else if (X[0] == 5)
            {
                Console.WriteLine($"Total: R$ {(Y[0] * 1.50).ToString("0.00")}");
            }
        }
    }
}
