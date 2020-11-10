using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircusTrein
{
    class Wagon
    {
        public int Punten { get; private set; }
        public int biggestCarn { get; private set; }
        public int id { get; private set; }
        List<Dier> Diers = new List<Dier>();

        public Wagon(int id )
        {
            this.id = id;
            Punten = 10;
        }

        public void getBigCarn()
        {
            int x = 0;
            foreach(Dier dier in Diers)
            {
                if(dier.eten.Equals(Dier.Eten.vlees) && Convert.ToInt32(dier.groote) > x)
                {
                    x = Convert.ToInt32(dier.groote);
                }
            }
            biggestCarn = x;
        }
        
        public void updatePunten()
        {
            int sum = 0;
            foreach(Dier x in Diers)
            {
                sum += Convert.ToInt32(x.groote);
            }
            Punten = 10 - sum;
        }
  
        public void addDier(Dier dier)
        {
            Diers.Add(dier);
            updatePunten();
            getBigCarn();
        }

        public override string ToString()
        {
            string temp = id.ToString() + ": ";
            foreach (Dier x in Diers)
            {
                temp += x.ToString();
            }

            return temp;
        }

    }
}
