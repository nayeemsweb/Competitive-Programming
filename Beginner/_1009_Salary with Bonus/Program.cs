using System;

namespace _1009_Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            var sellersName = Console.ReadLine();
            var salary = Convert.ToDouble(Console.ReadLine());
            var totalSales = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"TOTAL = R$ {(salary + (totalSales * 0.15)).ToString("0.00")}");

        }
    }
}
