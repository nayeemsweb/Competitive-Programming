using System;

namespace _1035_Selection_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            string[] divide = inputLine.Split(' ');

            int[] storeData = new int[divide.Length];

            for(var i=0; i<divide.Length; i++)
            {
                storeData[i] = int.Parse(divide[i]);
            }

            //storeData[0] = A
            //storeData[1] = B
            //storeData[2] = C
            //storeData[3] = D
            
            if ((storeData[1] > storeData[2]) && (storeData[3] > storeData[0]))
            {
                if((storeData[2] + storeData[3]) > (storeData[0] + storeData[1]))
                {
                    if((storeData[2] > 0) && (storeData[3] > 0))
                    {
                        if(storeData[0] % 2 == 0)
                        {
                            Console.WriteLine("Valores aceitos");
                        }
                        else
                        {
                            Console.WriteLine("Valores nao aceitos");
                        }
                    }
                }
            }
            
        }
    }
}
