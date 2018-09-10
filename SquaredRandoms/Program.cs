using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranNumList = new RanNumList();
            ranNumList.GenerateAndPrintRanNumList();

            Console.ReadLine();
        }
    }
}
