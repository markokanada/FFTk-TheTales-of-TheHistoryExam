using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FFTkTheTalesofTheHistoryExam.kviz
{

    class Kviz : Ikerdes
    {
        public Kviz()
        {
            beolvasas();
        }
        private string kerdes;
        public string KerdesekFeltevese { get { return kerdes; } private set { kerdes = value; } }

        private string[] valaszok;
        public string[] Valaszok { get { return valaszok; } private set { valaszok = value; } }

        private int pontszam;
        public int Pontszam { get { return pontszam; } private set { pontszam = value; } }

        private char megoldas;
        public char Megoldas { get { return megoldas; } private set { megoldas = value; } }
          
        public List<string[]> beolvasas()
        {

            StreamReader sr = new StreamReader("kviz.txt", Encoding.Default);
           
            List<string[]> kerdesek = new List<string[]>();

            //Kérdések adatai beolvasása 
            while (!sr.EndOfStream)
            {
                string[] seged = sr.ReadLine().Split(';');
                string[] sor = new string[] { seged[0], seged[1], seged[2], seged[3], seged[4], seged[5] };

                kerdesek.Add(sor);
            }

            sr.Close();
            return kerdesek;

        }

        //Kvíz Test

        public string kvizTest()
        {
            Kviz kivz = new Kviz();
            List<string[]> nev = kivz.beolvasas();
            for (int i = 0; i < nev.Count; i++)
            {

                KerdesekFeltevese = nev[i][0];
                valaszok= new string[] { nev[i][1], nev[i][2], nev[i][3] };
                Pontszam = int.Parse(nev[i][4]);
                Megoldas = char.Parse(nev[i][5]);
            }
            return "Hello Világ!";
        }

       
        


    }
}
