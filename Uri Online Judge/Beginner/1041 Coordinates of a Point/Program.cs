using System;

namespace _1041_Coordinates_of_a_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = new double[2];
            var userInput = Console.ReadLine();
            var divide = userInput.Split(' ');
            
            for (var i=0; i< coordinates.Length; i++)
            {
                coordinates[i] = double.Parse(divide[i]);
            }

            if(coordinates[0] == 0 && coordinates[1] == 0)
            {
                Console.WriteLine($"Origem");
            }
            else if(coordinates[0] == 0)
            {
                Console.WriteLine($"Eixo Y");
            }
            else if(coordinates[1] == 0)
            {
                Console.WriteLine($"Eixo X");
            }
            else if (coordinates[0] > 0 && coordinates[1] > 0)
            {
                Console.WriteLine($"Q1");
            }
            else if (coordinates[0] < 0 && coordinates[1] > 0)
            {
                Console.WriteLine($"Q2");
            }
            else if (coordinates[0] < 0 && coordinates[1] < 0)
            {
                Console.WriteLine($"Q3");
            }
            else if (coordinates[0] > 0 && coordinates[1] < 0)
            {
                Console.WriteLine($"Q4");
            }
        }
    }
}
