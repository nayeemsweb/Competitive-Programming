using System;

namespace _1018_Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNote = new int[] { int.Parse(Console.ReadLine()) };

            int[] banknotes = new int[] { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine(inputNote[0]);
            
            for (var i=0; i<banknotes.Length; i++)
            {
                Console.WriteLine($"{inputNote[0]/banknotes[i]} nota(s) de R$ {banknotes[i]},00");
                inputNote[0] = inputNote[0] % banknotes[i];
            }
        }
    }
}
