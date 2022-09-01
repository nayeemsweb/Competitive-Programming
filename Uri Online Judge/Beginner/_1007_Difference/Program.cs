using System;

namespace _1007_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var D = int.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENCA = {(A*B)-(C*D)}");
        }
    }
}
