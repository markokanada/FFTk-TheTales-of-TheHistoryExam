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
        public Kviz(string FajlNev)
        {
            beolvasas(FajlNev);
        }
        private string kerdes;
        public string KerdesekFeltevese { get { return kerdes; } private set { kerdes = value; } }

        private string[] valaszok;
        public string[] Valaszok { get { return valaszok; } private set { valaszok = value; } }

        private int pontszam;
        public int Pontszam { get { return pontszam; } private set { pontszam = value; } }

        private char megoldas;
        public char Megoldas { get { return megoldas; } private set { megoldas = value; } }
          

        //Beolvasás

        public List<string[]> beolvasas(string FajlNev)
        {

            StreamReader sr = new StreamReader("kviz/"+FajlNev, Encoding.Default);
           
            List<string[]> kerdesek = new List<string[]>();

            //Kérdések adatai beolvasása 
            while (!sr.EndOfStream)
            {
                string[] seged = sr.ReadLine().Split(';');
                string[] sor = new string[] { seged[0], seged[1], seged[2], seged[3], seged[4], seged[5]};

                kerdesek.Add(sor);
            }

            sr.Close();
            return kerdesek;

        }

        //Kvíz Test

        public string[] kvizTest(string FajlNev)
        {
            
            //Kvíz
            Kviz kivz = new Kviz(FajlNev);
            List<string[]> KvizAdatok = kivz.beolvasas(FajlNev);
            for (int i = 0; i < KvizAdatok.Count; i++)
            {

                KerdesekFeltevese = KvizAdatok[i][0];
                valaszok= new string[] { KvizAdatok[i][1], KvizAdatok[i][2], KvizAdatok[i][3] };
                Pontszam = int.Parse(KvizAdatok[i][4]);
                Megoldas = char.Parse(KvizAdatok[i][5]);
            }

            int Osszpont = 0;
            for (int i = 0; i < KvizAdatok.Count; i++)
            {
                Console.WriteLine(KvizAdatok[i][0]);
                Console.WriteLine(KvizAdatok[i][1]);
                Console.WriteLine(KvizAdatok[i][2]);
                Console.WriteLine(KvizAdatok[i][3]);
                Console.Write("Kérlek add meg a válaszod helyes betűjelét: ");
                string valasz = Console.ReadLine().ToUpper();
                if(valasz == KvizAdatok[i][5])
                {
                    Osszpont += 1;
                }

                Console.WriteLine();
            }

            //Megjelenítéshez 
            string[] megjelenites = new string[] { Osszpont.ToString() };

            return megjelenites;

        }





    }
}
