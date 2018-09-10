using System;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNum;

            for (int i = 0; i < 4; i++)
            {
                randNum = random.Next(100);
                Console.WriteLine(randNum);
            }

            Console.ReadLine();
        }
    }
}
