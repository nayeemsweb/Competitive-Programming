using System;

namespace _1008_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeNo = int.Parse(Console.ReadLine());
            var workedHours = int.Parse(Console.ReadLine());
            var hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"NUMBER = {employeeNo}");
            Console.WriteLine($"SALARY = U$ {(workedHours * hourlyRate).ToString("0.00")}");
        }
    }
}
