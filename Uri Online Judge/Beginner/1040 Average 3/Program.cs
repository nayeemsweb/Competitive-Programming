using System;

namespace _1040_Average_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] divide = input.Split(' ');
            double[] N1 = new double[1];
            double[] N2 = new double[1];
            double[] N3 = new double[1];
            double[] N4 = new double[1];

            for(var i=0; i<divide.Length; i++)
            {
                N1[0] = double.Parse(divide[0]);
                N2[0] = double.Parse(divide[1]);
                N3[0] = double.Parse(divide[2]);
                N4[0] = double.Parse(divide[3]);
            }

            var Average = ((N1[0] * 2) + (N2[0] * 3) + (N3[0] * 4) + (N4[0] * 1)) / (2 + 3 + 4 + 1);

            Console.WriteLine($"Media: {Average.ToString("0.0")}");

            //Approved Student
            if (Average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            //Reproved Student
            else if (Average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }

            //In exam student
            else if (Average >=5.0 && Average <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                var input2 = Console.ReadLine();
                var oneMoreScore = double.Parse(input2);
                
                //Exam score
                Console.WriteLine($"Nota do exame: {oneMoreScore.ToString("0.0")}");

                var recalculate = (oneMoreScore + Average) / 2;
                if (recalculate >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (recalculate <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                //Final average
                if (recalculate >= 5.0 || recalculate <= 4.9)
                {
                    Console.WriteLine($"Media final: {recalculate.ToString("0.0")}");
                }
            }
        }
    }
}
