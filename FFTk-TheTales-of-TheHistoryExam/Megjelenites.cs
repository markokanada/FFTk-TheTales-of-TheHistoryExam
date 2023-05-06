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
        public void palyaMegjelenites(string palyanev)
        {
            string filename = $"{palyanev}.txt";

            if (File.Exists($"{filename}"))
            {
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
        public void menuMegjelenites(int tipus) //0: üdvözlő képernyő 1: Főmenű, 2: story mode menü, 3: challenge mode menu 4: beállítások menü, 5: credits menu, 6: kilépés menü, 7: futás közbeni menü, 8: randomized töltő
        {



            if (tipus == 0)
            {
                Console.Clear();
                Console.Title = "\tFifght For The Knowdledge - The Tales of The History Exam";
                string brand = "brand.txt";
                var file = File.ReadAllLines(brand);
                int sorhossz = file[0].ToCharArray().Length;
                int sormagassag = file.Count();
                int counter = 0;

                string brand2 = "brand2.txt";
                var file2 = File.ReadAllLines(brand2);
                int sorhossz2 = file2[0].ToCharArray().Length;
                int sormagassag2 = file2.Count();
                int counter2 = 0;

                string brand3 = "brand3.txt";
                var file3 = File.ReadAllLines(brand3);
                int sorhossz3 = file3[0].ToCharArray().Length;
                int sormagassag3 = file3.Count();
                int counter3 = 0;

                string brand4 = "Készült a Pelican Entertainment 2023 által";
                int sorhossz4 = brand4.ToCharArray().Count();

                bool keyPressed = false;

                foreach (var sor3 in file3)
                {
                    Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz3) * 0.5), (Convert.ToInt32(sormagassag * 1.4)) + counter3);
                    Console.WriteLine(sor3);
                    counter3++;
                }

                foreach (var sor in file)
                {
                    Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz) * 0.5), 1 + counter);
                    Console.WriteLine(sor);
                    counter++;
                }

                Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz4) * 0.5), Convert.ToInt32(h * 0.95));
                Console.WriteLine(brand4);

                ConsoleKeyInfo keyInfo2;
                do
                {
                    keyInfo2 = Console.ReadKey();
                    if (keyInfo2.Key == ConsoleKey.E)
                    {
                        keyPressed = true;
                        menuMegjelenites(1);

                    }
                } while (keyInfo2.Key != ConsoleKey.Escape && !keyPressed);
                System.Environment.Exit(0);
            }

            if (tipus == 1)
            {
                Console.Clear();
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
                            Console.Write("  " + menuItems[i] + "  \n");
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
                        Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz2) * 0.7), (h - 1 - sormagassag2) + counter2);
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
                        Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz) * 0.7), 1 + counter);
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
                        if (menuItems[selectedIndex] == "  Story Mode  ")
                        {
                            menuMegjelenites(2);
                        }

                        if (menuItems[selectedIndex] == "   Kilépés    ")
                        {
                            System.Environment.Exit(0);
                        }
                        else { 
                        Console.WriteLine("A(z) " + menuItems[selectedIndex] + " opció lett kiválasztva.");
                        }
                        Console.ReadKey();

                    }

                }
            }

            if (tipus == 2)
            {
                Console.Clear();
                int spacing = (h - 15) / 2;

                Console.Title = "\tFifght For The Knowdledge - The Tales of The History Exam";
                Console.ForegroundColor = ConsoleColor.Green;

                string[] menuItems = { "Új játék kezdése", "Mentés betöltése" };
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
                            Console.Write("  " + menuItems[i] + "  \n");
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
                        Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz2) * 0.7), (h - 1 - sormagassag2) + counter2);
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
                        Console.SetCursorPosition(Convert.ToInt32((w - 0 - sorhossz) * 0.7), 1 + counter);
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
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        menuMegjelenites(1);
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
            if (tipus == 3)
            {

            }
            if (tipus == 4) { }
            if (tipus == 5) {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Yellow;

                string[] lines = {
            "PROJEKTVEZETŐ",
            "Buborék Márkó",
            "",
            "HELYETTES PROJEKTVEZETŐ",
            "Bacsa Dániel",
            "",
            "FEJLESZTŐK",
            "Fábián Szabolcs",
            "Molnár Márk",
            "Szász Csaba",
            "",
            "","",
        };

                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, Console.WindowHeight - 1);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }

                    string temp = lines[0];
                    for (int i = 1; i < lines.Length; i++)
                    {
                        lines[i - 1] = lines[i];
                    }
                    lines[lines.Length - 1] = temp;

                    System.Threading.Thread.Sleep(500);

                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }

                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Program leállítva, nyomj meg egy billentyűt a kilépéshez!");
                Console.ReadKey(true);
            }


            if (tipus == 6)
            {
                string[] kepernyoMentes = gyorsMentes();

                Console.Clear();
            }
            if (tipus == 7) { }


        }

        public string[] gyorsMentes()
        {
            string[] jelenlegi = new string[h];
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(0, i);
                jelenlegi[i] = Console.ReadLine();
            }

            return jelenlegi;
        }
    }
}

