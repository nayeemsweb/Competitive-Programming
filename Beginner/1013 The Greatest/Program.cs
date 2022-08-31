using System;

namespace _1013_The_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] divide = input.Split(' ');
            int[] array = new int[3];

            //Storing in Array
            for(var i=0; i< array.Length; i++)
            {
                array[i] = int.Parse(divide[i]);
            }
            
            //Sorting
            for(var i=0; i < array.Length; i++)
            {
                if(array[0] < array[i])
                {
                    array[0] = array[i];
                }
            }

            Console.WriteLine($"{array[0]} eh o maior");

        }
    }
}
