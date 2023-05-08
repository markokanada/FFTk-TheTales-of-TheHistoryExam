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
            kerdes = KerdesekFeltevese;
        }
        private string kerdes;
        public string KerdesekFeltevese { get { return kerdes; } private set { kerdes = value; } }

        public string[] Valaszok => throw new NotImplementedException();

        public int Pontszam => throw new NotImplementedException();

        public char Megoldas => throw new NotImplementedException();

        public void pass()
        {
            int OsszPontszam = 0;

            StreamReader sr = new StreamReader("kviz.txt", Encoding.UTF8);
            //Elsősor tartalmazza a kérdések számát. 
            int kerdesekSzama = int.Parse(sr.ReadLine());
            Ikerdes[] kerdesek = new Ikerdes[kerdesekSzama];

            //Kérdések adatai beolvasása 
            int i = 0;
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                KerdesekFeltevese = sor[0];
                string[] valaszok = new string[] { sor[1], sor[2], sor[3] };
                int pontszam = int.Parse(sor[4]);
                char megoldas = char.Parse(sor[5]);

                Ikerdes kerdesObjektum = new Kerdes(kerdes, valaszok, pontszam, megoldas);
                kerdesek[i] = kerdesObjektum;
                i++;
           
            }

            sr.Close();


            //
            
        }
    }
}
