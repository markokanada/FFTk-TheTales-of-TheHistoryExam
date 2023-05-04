using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal class SzobaFactory : ISzobaFactory
    {

        public int Id
        {
            get;
            private set;
        }

        public string Nev
        {
            get;
            private set;
        }
        public string Tortenet
        {
            get;
            private set;
        }
        public string KilepesiPont
        {
            get;
            private set;
        }

        //adatok beolvasása az "elhelyezendok1.txt" fájlból
        public ISzoba Letrehoz(int fileSor = 2)
        {
            Dictionary<string, string> elhelyezendoAdatok = new Dictionary<string, string>();

            string elhelyezendokFile = "elhelyezendok1.txt";

            StreamReader sr_elhelyezendokFile = new StreamReader(elhelyezendokFile);

            //for ciklus a sorok átugrása miatt kell
            for (int i = 0; i < fileSor + 1; i++)
            {
                //specifikus sor beolvasása és feldogozása
                if (i == fileSor)
                {
                    char sep = ';';
                    string[] seged = sr_elhelyezendokFile.ReadLine().Split(sep);

                    foreach (string item in seged)
                    {
                        string[] kulcsErtek = item.Split(':');
                        string kulcs = kulcsErtek[0].Replace("\"", "");
                        string ertek = kulcsErtek[1].Replace("\"", "");
                        elhelyezendoAdatok.Add(kulcs, ertek);
                    }

                    //Id = Convert.ToInt32(elhelyezendoAdatok["id"]);
                    //Nev = elhelyezendoAdatok["név"];
                    //Tortenet = elhelyezendoAdatok["Történet"];
                    //KilepesiPont = elhelyezendoAdatok["Kilépési_pont"];

                }
                else
                {
                    sr_elhelyezendokFile.ReadLine();
                }

            }
            sr_elhelyezendokFile.Close();
            return (ISzoba)elhelyezendoAdatok;
        }
    }
}