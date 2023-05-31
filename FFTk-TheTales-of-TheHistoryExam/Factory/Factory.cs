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
        public void Letrehoz(string szobaAdatokTXT, string ellenfelAdatokTXT, string npcAdatokTXT, string kuldetesAdatokTXT, string targyAdatokTXT)
        {
            #region szobaAdatok
            int szobaId = 0;
            string szobaNev = "";
            string szobaLeiras = "";
            string szobaTortenet = "";
            int ellenfelekSzama = 0;
            int npckSzama = 0;
            int kuldetesekSzama = 0;
            #endregion

            #region ellenfelAdatok
            int ellenfelId = 0;
            string ellenfelNev = "";
            string ellenfelLeiras = "";
            int ellenfelElet = 0;
            int ellenfelSebzesMertek = 0;
            int ellenfelVedelemMertek = 0;
            int ellenfelPancel = 0;
            bool ellenfelEletbenVan = true;

            #endregion

            #region npcAdatok
            //TO DO
            #endregion

            #region kuldetesAdatok
            //TO DO
            #endregion

            #region targyAdatok
            //TO DO
            #endregion


            StreamReader sr = new StreamReader($"SzobaAdatok/{szobaAdatokTXT}.txt", Encoding.UTF8);
            
            //szobaAdatokTXT
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(':');
                switch (sor[0])
                {
                    case "szobaId":
                        szobaId = int.Parse(sor[1]);
                        break;
                    case "szobaNev":
                        szobaNev = sor[1];
                        break;
                    case "szobaLeiras":
                        szobaLeiras = sor[1];
                        break;
                    case "szobaTortenet":
                        szobaTortenet = sor[1];
                        break;
                    case "ellenfelekSzama":
                        ellenfelekSzama = int.Parse(sor[1]);
                        break;
                    case "npckSzama":
                        npckSzama = int.Parse(sor[1]);
                        break;
                    case "kuldetesekSzama":
                        kuldetesekSzama = int.Parse(sor[1]);
                        break;
                }

            }
            sr.Close();
            Szoba szoba = new Szoba(szobaId, szobaNev, szobaLeiras, szobaTortenet, ellenfelekSzama, npckSzama, kuldetesekSzama);

        }

    }
}