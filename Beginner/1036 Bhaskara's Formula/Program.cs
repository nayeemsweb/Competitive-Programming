using System;

namespace _1036_Bhaskara_s_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] divide = input.Split(' ');
            double[] array = new double[divide.Length];
            
            for(var i=0; i<array.Length; i++)
            {
                array[i] = double.Parse(divide[i]);
            }

            /* we know,
                 Bhaskara's Formula =>x1 = (-b + sqrt(b^2 -4ac))/2a
                 Bhaskara's Formula =>x2 = (-b - sqrt(b^2 -4ac))/2a
                 
                 Here, Denominator have variable a, which cant be 0
                and, the sqrt must be greater than 0 
            */

            //array[0] = a
            //array[1] = b
            //array[2] = c
            
            var sqRoot = Math.Sqrt((Math.Pow(array[1], 2))-(4*array[0]*array[2]));

            var R1 = ((-1 * array[1]) + sqRoot) / (2 * array[0]);
            var R2 = ((-1 * array[1]) - sqRoot) / (2 * array[0]);

            if(sqRoot > 0 && array[0] != 0)
            {
                Console.WriteLine($"R1 = {R1.ToString("0.00000")}");
                Console.WriteLine($"R1 = {R2.ToString("0.00000")}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
