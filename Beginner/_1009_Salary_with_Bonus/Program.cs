using System;

namespace _1009_Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine();
            var userSalary = Convert.ToDouble(Console.ReadLine());
            var totalSale = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"TOTAL = R$ {(userSalary + (totalSale * 0.15)).ToString("0.00")}");
        }
    }
}
