using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrein
{
    class Wagons
    {

        public List<Dier> startDiers;

        public Wagons()
        {
            startDiers = new List<Dier> // niet hier instancieren maar door laten geven van program.cs
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

            int id = 0;
            foreach (Dier dier in startDiers)
            {
                
                dier.addID(id);
                id++;
            }
        }
  
        public List<Dier> sortList(List<Dier> dieren) // kan met linq
        {
            List<Dier> newList = new List<Dier>();
            int bM = 0;
            int mM = 0;
            int sM = 0;
            int bP = 0;
            int mP = 0;
            int sP = 0;

            foreach(Dier dier in dieren)
            {
                if(dier.groote == Dier.Groote.groot)
                {
                    if(dier.eten == Dier.Eten.vlees)
                    {
                        bM++;
                        newList.Insert(0, dier);

                    }
                    else if(dier.eten == Dier.Eten.planten)
                    {
                        bP++;
                        newList.Insert(bM, dier);
                    }
                }
                else if(dier.groote == Dier.Groote.middelmatig)
                {
                    if (dier.eten == Dier.Eten.vlees)
                    {
                        mM++;
                        newList.Insert(bM + bP, dier);

                    }
                    else if (dier.eten == Dier.Eten.planten)
                    {
                        mP++;
                        newList.Insert(bM + bP + mM, dier);
                    }
                }
                else if(dier.groote == Dier.Groote.klein)
                {
                    if (dier.eten == Dier.Eten.vlees)
                    {
                        sM++;
                        newList.Insert(bM + bP + mM + mP , dier);

                    }
                    else if (dier.eten == Dier.Eten.planten)
                    {
                        sP++;
                        newList.Insert(bM + bP + mM + mP + sM, dier);
                    }
                }
            }
            return newList;
        }

        public List<Wagon> sortDiers(List<Dier> dieren)
        {
            List<Wagon> wagons = new List<Wagon>();
            int id = 1;
            wagons.Add(new Wagon(0));
 
            foreach(Dier dier in dieren) // opsplitsen in 2 funcitien (geen bool) 1 zoekt wagon een maakt nieuwe wagon.
            {
                bool added = true;
                foreach(Wagon wagon in wagons.ToList())
                {
                    if(wagon.Punten >= (int) dier.groote && !(wagon.biggestCarn >= Convert.ToInt32(dier.groote))) //in wagon 
                    {
                        added = false;
                        wagon.addDier(dier);
                        break;
                    }
                }
                if (added)
                {
                    wagons.Add(new Wagon(id));
                    id++;
                    wagons[wagons.Count - 1].addDier(dier);
                }
            }
            return wagons;
        }

       

    }
}
