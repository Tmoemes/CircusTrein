using System;
using System.Collections.Generic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dier> dierList = new List<Dier> 
            {
                new Dier(Dier.Eten.planten,Dier.Groote.klein),
                new Dier(Dier.Eten.planten,Dier.Groote.klein),
                new Dier(Dier.Eten.planten,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.vlees,Dier.Groote.klein),
                new Dier(Dier.Eten.vlees,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.vlees,Dier.Groote.klein),
                new Dier(Dier.Eten.planten,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.vlees,Dier.Groote.klein),
                new Dier(Dier.Eten.planten,Dier.Groote.groot),
                new Dier(Dier.Eten.planten,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.planten,Dier.Groote.groot),
                new Dier(Dier.Eten.vlees,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.vlees,Dier.Groote.middelmatig),
                new Dier(Dier.Eten.planten,Dier.Groote.klein),
                new Dier(Dier.Eten.vlees,Dier.Groote.groot),
                new Dier(Dier.Eten.planten,Dier.Groote.klein),
                new Dier(Dier.Eten.vlees,Dier.Groote.groot)
            };


            Wagons test = new Wagons(dierList);
            List<Dier> testlist = test.SortList(test.startDiers);

            foreach(Dier dier in testlist)
            {
                Console.WriteLine(dierList.IndexOf(dier).ToString() + ": " +  dier.ToString());
            }

            List<Wagon> testWagons = test.sortDiers(testlist);

    
            foreach(Wagon wagon in testWagons)
            {
                Console.WriteLine(testWagons.IndexOf(wagon).ToString() + ": " + wagon.ToString());
            }
            Console.WriteLine(testWagons.Count);

        }
    }
}
