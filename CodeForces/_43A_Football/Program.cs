using System;

namespace _43A_Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var teamsArray = new string[lines];

            var counter1 = 0;
            var counter2 = 0;

            var firstTeam = "";
            var secondTeam = "";

            for(var i = 0; i < lines; i++)
            {
                teamsArray[i] = Console.ReadLine();
            }

            if (lines == 1)
            {
                firstTeam += teamsArray[0]; 
                counter1++;
            }
            else if (lines > 1)
            {
                firstTeam += teamsArray[0];
                for (var i = 0; i < lines; i++)
                {
                    if(teamsArray[i] != firstTeam)
                    {
                        secondTeam += teamsArray[i];
                        break;
                    }
                }
            }
            if (lines == 1) Console.WriteLine(firstTeam);
            if(lines > 1)
            {
                for(var i = 0; i < lines; i++)
                {
                    if(teamsArray[i] == firstTeam) counter1++;
                    else counter2++;
                }
            }
            
            if(lines > 1)
            {
                if (counter1 > counter2) Console.WriteLine(firstTeam);
                else Console.WriteLine(secondTeam);
            }
        }
    }
}
