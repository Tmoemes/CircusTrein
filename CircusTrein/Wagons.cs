using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CircusTrein
{
    class Wagons
    {

        public List<Dier> startDiers;

        public Wagons(List<Dier> startdiers)
        {
            startDiers = startdiers;
        }

        public List<Dier> SortList(List<Dier> dierList)
        {
            return dierList.OrderByDescending(x => x.groote).ThenByDescending(x => x.eten).ToList(); 
        }
  
        public List<Wagon> sortDiers(List<Dier> dieren)
        {
            List<Wagon> wagons = new List<Wagon>();
            wagons.Add(new Wagon());
            foreach(Dier dier in dieren) // opsplitsen in 2 funcitien (geen bool) 1 zoekt wagon een maakt nieuwe wagon.
            {
                Wagon x = null;
                foreach(Wagon wagon in wagons.ToList())
                {
                    if (wagon.HasSpace(dier))
                    {
                        x = wagon;
                        break;
                    }
                } 
                if(x != null)
                {
                    x.AddDier(dier);
                }
                else if(x == null)
                {
                    Wagon z = new Wagon();
                    z.AddDier(dier);
                    wagons.Add(z);
                }
            }
            return wagons;
        }

        /*public List<Dier> sortList(List<Dier> dieren) // kan met linq
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
        }*/
    }
}
