using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.kviz
{
    class Kerdes : Ikerdes
    {
        private string kerdesekFeltevese;
        private string[] valaszok;
        private int pontszam;
        private char megoldas;

        public Kerdes(string kerdes, string[] valaszok, int pontszam, char megoldas)
        {
            this.kerdesekFeltevese = kerdes;
            this.valaszok = valaszok;
            this.pontszam = pontszam;
            this.megoldas = megoldas;
        }

        public string KerdesekFeltevese
        {
            get { return kerdesekFeltevese; }
        }

        public string[] Valaszok
        {
            get { return valaszok; }
        }

        public int Pontszam
        {
            get { return pontszam; }
        }

        char Ikerdes.Megoldas => throw new NotImplementedException();

        //public char Megoldas(string valasz)
        //{
        //    return valasz.ToUpper() == megoldas.ToUpper();
        //}

        //string Ikerdes.Megoldas(string valasz)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
