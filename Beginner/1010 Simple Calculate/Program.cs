using System;

namespace _1010_Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            int[] code = new int[2];
            int[] unitsOfProduct = new int[2];
            double[] price = new double[2];

            string[] split1 = input1.Split(' ');
            string[] split2 = input2.Split(' ');

            unitsOfProduct[0] = int.Parse(split1[1]);
            unitsOfProduct[1] = int.Parse(split2[1]);

            price[0] = double.Parse(split1[2]);
            price[1] = double.Parse(split2[2]);

            var payment = (unitsOfProduct[0] * price[0]) + (unitsOfProduct[1] * price[1]);

            Console.WriteLine($"VALOR A PAGAR: R$ {payment.ToString("0.00")}");

        }
    }
}
