using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Dier
    {
        public enum Eten {vlees = 1,planten = 0};
        public enum Groote {klein = 1,middelmatig = 3,groot = 5};

        public Eten eten { get; private set; }
        public Groote groote { get; private set; }

        public Dier(Eten eten, Groote groote)
        {
            this.eten = eten;
            this.groote = groote;
        }
    
        public override string ToString()
        {
            return groote.ToString() + " " + eten.ToString() + ", ";
        }

    }
}
