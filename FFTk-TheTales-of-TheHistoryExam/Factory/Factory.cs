using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal class Factory
    {
        //adatok beolvasása fájlból
        public void Letrehoz()
        {
            int id = 0;
            string nev = "";
            string leiras = "";
            string tortenet = "";
            int ellenfelekSzama = 0;
            int npckSzama = 0;
            int kuldetesekSzama = 0;

            StreamReader sr = new StreamReader("SzobaAdatok/Szoba1Adatok.txt", Encoding.UTF8);
            
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(':');
                switch (sor[0])
                {
                    case "id":
                        id = int.Parse(sor[1]);
                        break;
                    case "nev":
                        nev = sor[1];
                        break;
                    case "leiras":
                        leiras = sor[1];
                        break;
                    case "tortenet":
                        tortenet = sor[1];
                        break;
                    case "ellenfelekszama":
                        ellenfelekSzama = int.Parse(sor[1]);
                        break;
                    case "npckszama":
                        npckSzama = int.Parse(sor[1]);
                        break;
                    case "kuldetesekszama":
                        kuldetesekSzama = int.Parse(sor[1]);
                        break;
                }

            }


            sr.Close();

        }

    }
}