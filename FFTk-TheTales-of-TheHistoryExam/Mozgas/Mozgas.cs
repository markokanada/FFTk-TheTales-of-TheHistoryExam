using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FFTkTheTalesofTheHistoryExam
{
    internal class Mozgas : IMozgas
    {

        Megjelenites megjelenites = new Megjelenites();

        private string[,] palya;

        public string[,] Palya
        {
            get
            {
                return palya;
            }
            private set
            {
                palya = value;
            }
        }


        public string[,] palyaBeolvasas(string fajlnev)
        {
            
            string[] lines = File.ReadAllLines(fajlnev);
            int SorokSzama = lines.Length;
            int  OszlopokSzama = lines[0].Length;

            string[,] matrix = new string[SorokSzama, OszlopokSzama];

            for (int i = 0; i < SorokSzama; i++)
            {
                for (int j = 0; j < OszlopokSzama; j++)
                {
                    matrix[i, j] = lines[i][j].ToString();
                }
            }

            return matrix;
        }

        public Mozgas()
        {
            Palya = palyaBeolvasas("pálya1.txt");
        }

        string[] NemLehetRalepni = new string[9] {"=>", "[", "]", "#", "!", "?", "X", "-", "*"};


        private int sebesseg;
        public int Sebesseg
        {
            get
            {
                return sebesseg;
            }
            set
            {
                if (value < 5 && value > 0)
                {
                    sebesseg = value;
                }
                else
                {
                    sebesseg = 1;
                }
            }
        }


        //jobb és bal
        public int minX { get; private set; }
        public int maxX { get; private set; }
        public int jelenlegiX
        {
            get 
            {
                return jelenlegiX;
            }
            private set 
            {
                for (int i = 0; i < palya.GetLength(0); i++)
                {
                    for (int j = 0; j < palya.GetLength(1); j++)
                    {
                        if (palya[i, j] == "X" && palya[i, j - 1] != "[")
                        {
                            jelenlegiX = i;
                        }
                    }
                }
            }
        }

        //fel és le
        public int minY { get; private set; }
        public int maxY { get; private set; }
        public int jelenlegiY
        {
            get
            {
                return jelenlegiY;
            }
            private set
            {
                for (int i = 0; i < palya.GetLength(0); i++)
                {
                    for (int j = 0; j < palya.GetLength(1); j++)
                    {
                        if (palya[i, j] == "X" && palya[i, j-1] != "[")
                        {
                            jelenlegiY = j;
                        }
                    }
                }
            }
        }




        public void Balra()
        {

            if (NemLehetRalepni.Contains(palya[jelenlegiX - 1, jelenlegiY]) == false)
            {
                if (jelenlegiX > minX && 1 > minX)
                {
                    jelenlegiX -= 1;
                }
            }
           
        }
        public void Jobbra()
        {
            if (NemLehetRalepni.Contains(palya[jelenlegiX + 1, jelenlegiY]) == false)
            {
                if (jelenlegiX < maxX && 1 < maxX)
                {
                    jelenlegiX += 1;
                }
            }

        }
        public void Fel()
        {
            if (NemLehetRalepni.Contains(palya[jelenlegiX, jelenlegiY - 1]) == false)
            {
                if (jelenlegiY > minY && 1 > minY)
                {
                    jelenlegiY -= 1;
                }
            }

        }
        public void Le()
        {
            if(NemLehetRalepni.Contains(palya[jelenlegiX, jelenlegiY + 1]) == false)
            {
                if (jelenlegiY < maxY && 1 < maxY)
                {
                    jelenlegiY += 1;
                }
            }
        }

        public void Noveles(int mertek)
        {
            Sebesseg += mertek;
        }

        public string Adatok()
        {
            return $"maxX -> {maxX}\nmaxY -> {maxY}\nminX -> {minX}\nmaxY -> {maxY}\njelenlegiX -> {jelenlegiX}\njelenlegiY -> {jelenlegiY}";
        }
    }
}
