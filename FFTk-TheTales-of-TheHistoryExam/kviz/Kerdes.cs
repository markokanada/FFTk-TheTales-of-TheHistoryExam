using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.kviz
{
    class Kerdes : Ikerdes
    {
        private string kerdes;
        private string[] valaszok;
        private int pontszam;
        private string megoldas;

        public Kerdes(string kerdes, string[] valaszok, int pontszam, string megoldas)
        {
            this.kerdes = kerdes;
            this.valaszok = valaszok;
            this.pontszam = pontszam;
            this.megoldas = megoldas;
        }

        public string Kerdes
        {
            get { return kerdes; }
        }

        public string[] Valaszok
        {
            get { return valaszok; }
        }

        public int Pontszam
        {
            get { return pontszam; }
        }

        public bool Megoldas(string valasz)
        {
            return valasz.ToUpper() == megoldas.ToUpper();
        }

        string Ikerdes.Megoldas(string valasz)
        {
            throw new NotImplementedException();
        }
    }
}
