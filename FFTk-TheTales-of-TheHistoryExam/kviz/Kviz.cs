using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FFTkTheTalesofTheHistoryExam
{

    class Kviz : Ikerdes
    {
        public Kviz(string FajlNev)
        {
            beolvasas(FajlNev);
        }
        private string[] kerdes;
        public string[] KerdesekFeltevese { get { return kerdes; } private set { kerdes = value; } }

        private string[] valaszok;
        public string[] Valaszok { get { return valaszok; } private set { valaszok = value; } }

        private int pontszam;
        public int Pontszam { get { return pontszam; } private set { pontszam = value; } }

        private char megoldas;
        public char Megoldas { get { return megoldas; } private set { megoldas = value; } }
          

        //Beolvasás

        public List<string[]> beolvasas(string FajlNev)
        {

            StreamReader sr = new StreamReader("kviz/"+FajlNev, Encoding.UTF8);
           
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
        private int pont;
        //Kvíz Test
        public int Pont()
        {
            
            return pont;
        }

        private List<string> kerdesek = new List<string>();
        public List<string> Kerdesek()
        {

            return kerdesek;
        }

        public string kvizTest(string FajlNev)
        {
            
            //Kvíz
            Kviz kivz = new Kviz(FajlNev);
            List<string[]> KvizAdatok = kivz.beolvasas(FajlNev);
            for (int i = 0; i < KvizAdatok.Count; i++)
            {

                kerdesek.Add(KvizAdatok[i][0]);
                kerdesek.Add(KvizAdatok[i][1]);
                kerdesek.Add(KvizAdatok[i][2]);
                kerdesek.Add(KvizAdatok[i][3]);
                kerdesek.Add(KvizAdatok[i][4]);
                kerdesek.Add(KvizAdatok[i][5]);
            }

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
                    pont += 1;
                    Pont();
                }
                
                Console.Clear();
            }

            //Megjelenítéshez 
            

            string megjelenites =  "Elért pontszám: " + pont.ToString() ;
            return megjelenites;

            

        }

        public void pontElmentese()
        {
            StreamReader file_r = new StreamReader("kviz/legmagasabbPontszam.txt", Encoding.UTF8);
            int pontszam = int.Parse(file_r.ReadLine());

            file_r.Close();
            if (pont > pontszam)
            {
                StreamWriter file_a = new StreamWriter("kviz/legmagasabbPontszam.txt", false, Encoding.UTF8);

                file_a.WriteLine(pont);

                file_a.Close();

                Console.WriteLine("Megdöntötted a rekordodat.");
            }


        }

    }
}
