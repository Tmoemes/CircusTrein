using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircusTrein
{
    class Wagon
    {
        public int Punten { get; private set; } = 10;
        public int biggestCarn { get; private set; }
        List<Dier> Diers = new List<Dier>();

        public void getBigCarn()
        {
            int x = 0;
            foreach(Dier dier in Diers)
            {
                if(dier.eten.Equals(Dier.Eten.vlees) && (int) dier.groote > x)
                {
                    x = (int) dier.groote;
                }
            }
            biggestCarn = x;
        }
        
        public void updatePunten()
        {
            int sum = 0;
            foreach(Dier x in Diers)
            {
                sum += (int) x.groote;
            }
            Punten = 10 - sum;
        }

        public bool HasSpace(Dier dier)
        {
            if (Punten >= (int)dier.groote && !(biggestCarn >= (int)dier.groote))
            {
                return true;
            }
            else return false;
        }

        public void AddDier(Dier dier)
        {
            if (Punten >= (int)dier.groote && !(biggestCarn >= (int)dier.groote))
            {
                Diers.Add(dier);
                updatePunten();
                getBigCarn();
            }
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Dier x in Diers)
            {
                temp += x.ToString();
            }

            return temp;
        }

    }
}
