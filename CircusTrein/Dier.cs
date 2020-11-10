using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Dier
    {
        public enum Eten {vlees,planten};
        public enum Groote {klein = 1,middelmatig = 3,groot = 5};

        public Eten eten { get; private set; }
        public Groote groote { get; private set; }
        public int id { get; private set; } // geen id toevoegen als deze niet nodig is voor functionaliteit, test aanpassen aan logica niet logica aan test

        public Dier(Eten eten, Groote groote)
        {
            this.eten = eten;
            this.groote = groote;
        }
    
        public void addID(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return id.ToString() + ": " + groote.ToString() + " " + eten.ToString() + ", ";
        }

    }
}
