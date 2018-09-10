using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredRandoms
{
    class RanNumList
    {
        Random random = new Random();
        List<int> ranNumList = new List<int>();
        List<int> ranNumListSq = new List<int>();

        private void GenerateRanNumList()
        {
            for(int i = 0; i < 20; i++)
            {
                ranNumList.Add(random.Next(50));
            }
        }

        private void PrintRanNumList()
        {
            foreach(int ranNum in ranNumList)
            {
                Console.WriteLine($"ranNum: {ranNum}");
            }
        }

        private void GenerateSquaredNumList()
        {
            foreach(int ranNum in ranNumList)
            {
                var itemSquared = ranNum * ranNum;
                ranNumListSq.Add(itemSquared);
            }
        }

        private void PrintSquaredNumList()
        {
            foreach(int item in ranNumListSq)
            {
                Console.WriteLine($"squaredNum: {item}");
            }
        }

        private void RemoveOddNumbersFromSquaredList()
        {
            foreach(int item in ranNumListSq)
            {
                if ((item % 2) != 0)
                {
                    ranNumListSq.Remove(item);
                }
                else
                {
                    Console.WriteLine($"notOdd: {item}");
                }
            }
        }

        public void GenerateAndPrintRanNumList()
        {
            GenerateRanNumList();
            PrintRanNumList();
            GenerateSquaredNumList();
            PrintSquaredNumList();
            RemoveOddNumbersFromSquaredList();
        }
    }
}
