using System;
using System.Collections.Generic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Wagons test = new Wagons();
            List<Dier> testlist = test.sortList(test.startDiers);

            foreach(Dier dier in testlist)
            {
                Console.WriteLine(dier.ToString());
            }

            List<Wagon> testWagons = test.sortDiers(testlist);
            
            foreach(Wagon wagon in testWagons)
            {
                Console.WriteLine(wagon.ToString());
            }
            Console.WriteLine(testWagons.Count);

        }
    }
}
