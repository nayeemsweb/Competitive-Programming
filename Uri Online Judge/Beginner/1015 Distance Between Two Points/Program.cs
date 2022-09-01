using System;

namespace _1015_Distance_Between_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            double[] p1 = new double[2];
            double[] p2 = new double[2];

            string[] divide1 = input1.Split(' ');
            string[] divide2 = input2.Split(' ');

            //Storing the vaues in Arrays
            for(var i=0; i<2; i++)
            {
                p1[i] = double.Parse(divide1[i]);
                p2[i] = double.Parse(divide2[i]);
            }

            //Printing
            var distance = Math.Sqrt((Math.Pow((p2[0] - p1[0]), 2)) + (Math.Pow((p2[1] - p1[1]), 2)));
            Console.WriteLine(distance.ToString("0.0000"));
            
        }
    }
}
