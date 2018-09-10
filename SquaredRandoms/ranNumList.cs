using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredRandoms
{
    class RanNumList
    {
        Random random = new Random();
        List<int> ranNumList = new List<int>();

        public void GenerateRanNumList()
        {
            for(int i = 0; i < 20; i++)
            {
                ranNumList.Add(random.Next(50));
            }
        }

        //private void PrintRanNumList()
        //{
        //    foreach(int ranNum in ranNumList)
        //    {
        //        Console.WriteLine($"ranNum: {ranNum}");
        //    }
        //}

        public void GenerateAndPrintRanNumList()
        {
            GenerateRanNumList();
            //PrintRanNumList();
        }
    }
}
