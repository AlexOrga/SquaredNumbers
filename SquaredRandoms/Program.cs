using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranNumList = new RanNumList();
            RanNumList randomNumbersList = ranNumList.GenerateRanNumList();
            RanNumListSquared
            //Random random = new Random();

            //List<int> ranNumList = new List<int>();
            //List<int> ranNumListSquared = new List<int>();

            ////for (int i = 0; i < 20; i++)
            //{
            //    ranNumList.Add(random.Next(50));
            //}

            //foreach(int ranNum in ranNumList)
            //{
            //    int ranNumSquared = ranNum * ranNum;
            //    ranNumListSquared.Add(ranNumSquared);
            //}

            Console.ReadLine();
        }
    }
}
