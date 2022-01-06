using System;

namespace _266B_Queue_at_the_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine().Split(' ');
            var childrenQueue = Console.ReadLine().ToCharArray();

            var numOfChildren = int.Parse(userInput[0]);
            var time = int.Parse(userInput[1]);

            for(var i = 0; i < time; i++)
            {
                for(var j = 0; j < childrenQueue.Length - 1; j++)
                {
                    if(childrenQueue[j] == 'B' && childrenQueue[j+1] == 'G')
                    {
                        childrenQueue[j] = 'G';
                        childrenQueue[j + 1] = 'B';
                        j++;
                    }
                }
            }
            Console.WriteLine(childrenQueue);
        }
    }
}
