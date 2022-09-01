using System;

namespace _1021_Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNote = new double[] { double.Parse(Console.ReadLine()) };

            if(inputNote[0] >= 0 && inputNote[0] <= 1000000.00)
            {
                int[] banknotes = new int[] { 100, 50, 20, 10, 5, 2 };
                double[] coins = new double[] { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

                Console.WriteLine("NOTAS:");
                for (var i = 0; i < banknotes.Length; i++)
                {
                    Console.WriteLine($"{Math.Floor(inputNote[0] / banknotes[i])} nota(s) de R$ {banknotes[i].ToString("0.00")}");
                    inputNote[0] = inputNote[0] % banknotes[i];
                }

                Console.WriteLine("MOEDAS:");
                for (var j = 0; j < coins.Length; j++)
                {
                    Console.WriteLine($"{Math.Floor(inputNote[0] / coins[j])} moeda(s) de R$ {coins[j].ToString("0.00")}");
                    inputNote[0] = inputNote[0] % coins[j];
                }
            }
        }
    }
}
