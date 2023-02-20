using System;

namespace _110A_Nearly_Lucky_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input  = Console.ReadLine().ToCharArray();

            if (input.Length <= Math.Pow(10, 18)) 
            {
                var count = 0;
                foreach (char c in input)
                {
                    if (c == '-')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    
                    var number = int.Parse(c.ToString());

                    if (number == 4 || number == 7)
                    {
                        count++;
                    }
                    else
                        break;
                }

                if (count == 4 || count == 7)
                {
                    Console.WriteLine("YES");
                }
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
