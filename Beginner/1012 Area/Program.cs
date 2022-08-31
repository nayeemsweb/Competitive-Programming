using System;

namespace _1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] divide = input.Split(' ');
            var A = double.Parse(divide[0]);
            var B = double.Parse(divide[1]);
            var C = double.Parse(divide[2]);

            Console.WriteLine($"TRIANGULO: {((1.0/2) * A * C).ToString("0.000")}");
            Console.WriteLine($"CIRCULO: {(3.14159 * (Math.Pow(C, 2))).ToString("0.000")}");
            Console.WriteLine($"TRAPEZIO: {((1.0 / 2) * (A + B) * C).ToString("0.000")}");
            Console.WriteLine($"QUADRADO: {(Math.Pow(B, 2)).ToString("0.000")}");
            Console.WriteLine($"RETANGULO: {(A * B).ToString("0.000")}");
        }
    }
}
