using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal class Szoba : ISzoba
    {
        public int Id
        {
            get
            {
                return Id;
            }
            private set
            {
                Id = value;
            }
        }

        public string Nev
        {
            get
            {
                return Nev;
            }
            private set
            {
                Nev = value;
            }
        }

        public string Leiras
        {
            get
            {
                return Leiras;
            }
            private set
            {
                Leiras = value;
            }
        }

        public string Tortenet
        {
            get
            {
                return Tortenet;
            }
            private set
            {
                Tortenet = value;
            }
        }

        public int EllenfelekSzama
        {
            get
            {
                return EllenfelekSzama;
            }
            private set
            {
                EllenfelekSzama = value;
            }
        }

        public int NPCkSzama
        {
            get
            {
                return NPCkSzama;
            }
            private set
            {
                EllenfelekSzama = value;
            }
        }

        public int KuldetesekSzama
        {
            get
            {
                return KuldetesekSzama;
            }
            private set
            {
                KuldetesekSzama = value;
            }
        }

        public List<string> Targyak { get; private set; }

        public Szoba(int szobaId, string szobaNev, string szobaLeiras, string szobaTortenet, int ellenfelekSzama, int npckSzama, int kuldetesekSzama)
        {
            Id = szobaId;
            Nev = szobaNev;
            Leiras = szobaLeiras;
            Tortenet = szobaTortenet;
            EllenfelekSzama = ellenfelekSzama;
            NPCkSzama = npckSzama;
            KuldetesekSzama = kuldetesekSzama;
        }
    }
}
