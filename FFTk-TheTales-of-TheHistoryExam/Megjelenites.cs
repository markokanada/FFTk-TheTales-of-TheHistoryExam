using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Megjelenites
    {
        public int w = Console.WindowWidth;
        public int h = Console.WindowHeight;
        public void palyaMegjelenites(string palyanev) {
            string filename = $"{palyanev}.txt";

            if (File.Exists($"{filename}")) {
                var file = File.ReadAllLines(filename);
                int sorhossz = 0;
                int sormagassag = file.Count();
                foreach (var row in file)
                {
                    bool balSzel = false;
                    bool jobbSzel = false;
                    char[] rows = row.ToCharArray();
                    sorhossz = row.Length;

                    for (int i = 0; i < sorhossz; i++)
                    {
                        if (i < sorhossz / 2 && rows[i] == '#')
                        {
                            balSzel = true;
                        }
                        else if ((balSzel && rows[i] == '#') && (i + 1 != sorhossz - 1 && rows[i + 1] != '#'))
                        {
                            jobbSzel = true;
                        }

                        else if ((i > sorhossz / 2 && jobbSzel) || (i < sorhossz / 2 && !balSzel) || (!balSzel && !jobbSzel))
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Console.Write(rows[i]);
                        if (i == sorhossz - 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            for (int k = 0; k < w - sorhossz - 1; k++)
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    Console.Write("\n");

                }
                for (int i = 0; i < h - sormagassag; i++)
                {
                    for (int j = 0; j < w - 1; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(' ');
                    }
                    Console.Write("\n");
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public string[,] Palya(string palyanev)
        {
            string filename = $"{palyanev}.txt";

            if (File.Exists($"{filename}"))
            {
                var file = File.ReadAllLines(filename);

                string[,] matrix = new string[file[0].Length, file.Count()];
                for (int i = 0; i < file.Count(); i++)
                {
                    for (int j = 0; j < file[0].Length; j++)
                    {
                        matrix[i, j] = file[i].ToCharArray()[j].ToString();
                    }
                }

                return matrix;
            }
            return null;
        }

        public void GombMegjelenites(string szoveg)
        {
            Console.SetCursorPosition(Convert.ToInt32(w * 0.05), Convert.ToInt32(h * 0.95));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(szoveg);
        }

        public void ParbeszedMegjelenites(string parbeszedAdatok)
        {
            string filename = $"{parbeszedAdatok}.txt";
            string filename2 = "parbeszedSablon.txt";
            string filename3 = $"face.txt";
        }
        public void menuMegjelenites()
        {
            int spacing = (h - 15) / 6;

            Console.Title = "\tFifght For The Knowdledge - The Tales of The History Exam";
            Console.ForegroundColor = ConsoleColor.Green;

            string[] menuItems = { "  Story Mode  ", "Challenge Mode", " Beállítások  ", "   Credits    ", "   Kilépés    " };
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < spacing; i++)
                {
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n\n\n\n\n\n\n\n");

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\t");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  "+menuItems[i] + "  \n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Write("\t");
                        Console.Write("  " + menuItems[i] + "  \n");
                    }

                    Console.WriteLine("\n");
                }

                string brand2 = "brand2.txt";
                var file2 = File.ReadAllLines(brand2);
                int sorhossz2 = file2[0].ToCharArray().Length;
                int sormagassag2 = file2.Count();
                int counter2 = 0;
                foreach (var sor2 in file2)
                {
                    Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz2) * 0.7), (h -1 - sormagassag2)+counter2);
                    Console.WriteLine(sor2);
                    counter2++;
                }

                string brand = "brand.txt";
                var file = File.ReadAllLines(brand);
                int sorhossz = file[0].ToCharArray().Length;
                int sormagassag = file.Count();
                int counter = 0;
                foreach (var sor in file)
                {
                    Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz) * 0.7), 1+ counter);
                    Console.WriteLine(sor);
                    counter++;
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;

                    if (selectedIndex < 0)
                    {
                        selectedIndex = menuItems.Length - 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;

                    if (selectedIndex >= menuItems.Length)
                    {
                        selectedIndex = 0;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("A(z) " + menuItems[selectedIndex] + " opció lett kiválasztva.");
                    Console.ReadKey();
                    if (menuItems[selectedIndex] == "Kilépés")
                    {
                        break;
                    }
                }


            }





        }
    }
}

