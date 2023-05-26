using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Mozgas : IMozgas
    {
        Harc harc = new Harc();
        static List<Ellenfel> ellenfelek = new List<Ellenfel>();
        Raktar raktar = new Raktar(10);

        private int PalyaIndex = 1;

        public void Interakcio()
        {
            Console.Write("Utadat egy ellenség állja, szeretnél harcolni vele ? I/N: ");
            string SzeretneHarcolniVagySem = Console.ReadLine();

            if (SzeretneHarcolniVagySem == "I" || SzeretneHarcolniVagySem == "i")
            {
                harc.Harcolas(ellenfelek[0]);

                if (harc.Elpusztitas(ellenfelek[0]))
                {
                    palya[jelenlegiY + 1, jelenlegiX] = " ";
                    palya[jelenlegiY + 1, jelenlegiX - 1] = " ";
                    palya[jelenlegiY + 1, jelenlegiX + 1] = " ";
                    ellenfelek.RemoveAt(0);
                }
            }
        }

        public int EllenfelDarab()
        {
            int ellenfeldb = 0;

            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    if (Palya[i, j] == "!")
                    {
                        ellenfeldb++;
                    }
                }
            }

            return ellenfeldb;
        }

        public void EllenfelCsinalas()
        {
            for (int i = 0; i < EllenfelDarab(); i++)
            {
                Ellenfel ellenfel = new Ellenfel();
                ellenfelek.Add(ellenfel);
            }
        }

        public int PalyaIndexNoveles()
        {
            PalyaIndex++;
            return PalyaIndex;
        }

        public int PalyaIndexCsokkentes()
        {
            PalyaIndex--;
            return PalyaIndex;
        }

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
            Palya = palyaBeolvasas($"pálya{PalyaIndex}.txt");
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

        //X és Y koordináta tömb, ha null, akkor nincs ajtó
        public int[] FentiAjto()
        {
            int[] fentiAjtoYX = new int[2];

            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    if (Palya[i, j] == "A" && Palya[i, j - 1] == "[" && Palya[i ,j + 1] == "]" && i < 10)
                    {
                        fentiAjtoYX[0] = i;
                        fentiAjtoYX[1] = j;
                    }
                }
            }

            return fentiAjtoYX;
        }

        public int[] LentiAjto()
        {
            int[] lentiAjtoXY = new int[2];

            for (int i = 0; i < Palya.GetLength(0); i++)
            {
                for (int j = 0; j < Palya.GetLength(1); j++)
                {
                    if (Palya[i, j] == "A" && Palya[i, j - 1] == "[" && Palya[i, j + 1] == "]" && i > 10)
                    {
                        lentiAjtoXY[0] = i;
                        lentiAjtoXY[1] = j;
                        
                    }
                }
            }

            return lentiAjtoXY;
        }

        
        public void MozgasAPalyan()
        {
            Console.ResetColor();
            EllenfelDarab();
            EllenfelCsinalas();
            bool playing = true;
            while (playing)
            {
                int[] lentiAjtoYX = LentiAjto();
                int[] fentiAjtoYX = FentiAjto();
                Console.CursorVisible = false;

                if (Palya[jelenlegiY + 1, jelenlegiX] == "!")
                {
                    Interakcio();
                }
                else if (Palya[jelenlegiY + 1, jelenlegiX] == "?" || Palya[jelenlegiY - 1, jelenlegiX] == "?")
                {
                    Random rnd = new Random();

                    int[] targyHelyeYX = new int[2];

                    if (Palya[jelenlegiY + 1, jelenlegiX] == "?")
                    {
                        targyHelyeYX[0] = jelenlegiY + 1; targyHelyeYX[1] = jelenlegiX;
                    }
                    else
                    {
                        targyHelyeYX[0] = jelenlegiY - 1; targyHelyeYX[1] = jelenlegiX;
                    }

                    string targyNeve = raktar.felvehetoTargyak[rnd.Next(0, raktar.felvehetoTargyak.Count)];
                    Console.Write($"A földön hever egy {targyNeve}, elteszed a raktáradba ? I/N: ");
                    string targyInputValasz = Console.ReadLine();
                    Console.Clear();

                    if (targyInputValasz == "I")
                    {
                        raktar.TargyHozzadas(targyNeve);


                        if (jelenlegiY < targyHelyeYX[0])
                        {
                            palya[jelenlegiY + 1, jelenlegiX] = " ";
                            palya[jelenlegiY + 1, jelenlegiX - 1] = " ";
                            palya[jelenlegiY + 1, jelenlegiX + 1] = " ";
                        }
                        else
                        {
                            palya[jelenlegiY - 1, jelenlegiX] = " ";
                            palya[jelenlegiY - 1, jelenlegiX - 1] = " ";
                            palya[jelenlegiY - 1, jelenlegiX + 1] = " ";
                        }
                    }
                }

                for (int i = 0; i < Palya.GetLength(0); i++)
                {
                    for (int j = 0; j < Palya.GetLength(1); j++)
                    {
                        
                        //print player
                        if (i == jelenlegiY && j == jelenlegiX)
                        {
                            Palya[jelenlegiY, jelenlegiX] = " ";
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("X");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(Palya[i, j]);
                        }

                    }
                    Console.WriteLine();
                }

                Console.Write($"Életerő: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(harc.Elet);
                Console.ResetColor();
                Console.Write($"Páncél: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(harc.Pancel);
                Console.ResetColor();
                if (harc.Elet < 70)
                {
                    Console.WriteLine("élet töltése -> \"g\"");
                }

                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow && NemLehetRalepni.Contains(palya[jelenlegiY - 1, jelenlegiX]) == false)
                {
                    Fel();
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && NemLehetRalepni.Contains(palya[jelenlegiY + 1, jelenlegiX]) == false)
                {
                    Le();
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow && NemLehetRalepni.Contains(palya[jelenlegiY, jelenlegiX + 1]) == false)
                {
                    Jobbra();
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && NemLehetRalepni.Contains(palya[jelenlegiY, jelenlegiX - 1]) == false)
                {
                    Balra();
                }
                //kilépés
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    playing = false;
                }
                else if (keyInfo.Key == ConsoleKey.G && harc.Elet < 70)
                {
                    harc.Elet += 50;
                }
                else if (keyInfo.Key == ConsoleKey.Tab)
                {
                    raktar.raktarInterakcio();
                }




                if (lentiAjtoYX.Length != 0)
                {
                    if (jelenlegiY == lentiAjtoYX[0] && jelenlegiX == lentiAjtoYX[1])
                    {
                        PalyaIndex = PalyaIndexNoveles();
                        Palya = palyaBeolvasas($"pálya{PalyaIndex}.txt");
                        EllenfelDarab();
                        EllenfelCsinalas();
                        jelenlegiY = 0;
                        jelenlegiX = 0;


                    }
                }
                if (fentiAjtoYX.Length != 0)
                {
                    if (jelenlegiY == fentiAjtoYX[0] && jelenlegiX == fentiAjtoYX[1])
                    {
                        PalyaIndex = PalyaIndexCsokkentes();
                        Palya = palyaBeolvasas($"pálya{PalyaIndex}.txt");
                        EllenfelDarab();
                        EllenfelCsinalas();
                        jelenlegiY = 0;
                        jelenlegiX = 0;

                    }
                }


                



                Console.Clear();
            }
            
        }

    }
}
