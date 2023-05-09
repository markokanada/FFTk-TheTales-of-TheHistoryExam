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


        private string[,] palya;

        public string[,] Palya
        {
            get
            {
                return palya;
            }
            private set
            {
                if (value != null)
                {
                    palya = value;
                }
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
            jelenlegiY = 0;
            jelenlegiX = 0;
        }

        string[] NemLehetRalepni = new string[] {"=", ">", "[", "]", "#", "!", "?", "X", "-", "*"};


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

        private int jelenlegix;
        public int jelenlegiX
        {
            get 
            {
                return jelenlegix;
            }
            private set 
            {
                for (int i = 0; i < Palya.GetLength(0); i++)
                {
                    for (int j = 0; j < Palya.GetLength(1); j++)
                    {
                        if (Palya[i, j] == "X" && Palya[i, j - 1] != "[")
                        {
                            jelenlegix = j;
                        }
                    }
                }
            }
        }

        //fel és le
        public int minY { get; private set; }
        public int maxY { get; private set; }
        private int jelenlegiy;
        public int jelenlegiY
        {
            get
            {
                return jelenlegiy;
            }
            private set
            {
                for (int i = 0; i < Palya.GetLength(0); i++)
                {
                    for (int j = 0; j < Palya.GetLength(1); j++)
                    {
                        if (Palya[i, j] == "X" && Palya[i, j-1] != "[")
                        {
                            jelenlegiy = i;
                        }
                    }
                }
            }
        }




        public void Balra()
        {

            if (NemLehetRalepni.Contains(Palya[jelenlegiY, jelenlegiX - 1]) == false)
            {
                jelenlegix -= 1;
                //if (jelenlegiX > minX && 1 > minX)
                //{
                //}
            }
           
        }
        public void Jobbra()
        {
            if (NemLehetRalepni.Contains(Palya[jelenlegiY, jelenlegiX + 1]) == false)
            {

                jelenlegix += 1;
                //if (jelenlegiX < maxX && 1 < maxX)
                //{
                    
                //}
            }

        }
        public void Fel()
        {
            if (NemLehetRalepni.Contains(palya[jelenlegiY - 1, jelenlegiX]) == false)
            {
                jelenlegiy -= 1;
                //if (jelenlegiY > minY && 1 > minY)
                //{
                    
                //}
            }

        }
        public void Le()
        {
            if(NemLehetRalepni.Contains(palya[jelenlegiY + 1, jelenlegiX]) == false)
            {
                jelenlegiy += 1;
                //if (jelenlegiY < maxY && 1 < maxY)
                //{
                    
                //}
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


        public void MozgasAPalyan()
        {
            while (true)
            {

                for (int i = 0; i < Palya.GetLength(0); i++)
                {
                    for (int j = 0; j < Palya.GetLength(1); j++)
                    {
                        
                        //print player
                        if (i == jelenlegiY && j == jelenlegiX)
                        {
                            palya[jelenlegiY, jelenlegiX] = " ";
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(Palya[jelenlegiY, jelenlegiX]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(Palya[i, j]);
                        }
                        
                    }
                    Console.WriteLine();
                }

                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Fel();
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Le();
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Jobbra();
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Balra();
                }

                Console.Clear();
            }
        }

    }
}
