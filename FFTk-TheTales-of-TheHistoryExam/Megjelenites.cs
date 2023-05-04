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
                    if(i < sorhossz / 2 && rows[i] == '#')
                    {
                        balSzel = true;
                    }
                    else if ((balSzel && rows[i] == '#') && (i+1 != sorhossz-1 && rows[i+1] != '#'))
                    {
                        jobbSzel = true;
                    }

                    else if((i > sorhossz / 2 && jobbSzel) || (i < sorhossz / 2 && !balSzel )|| (!balSzel && !jobbSzel))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                     Console.Write(rows[i]);
                        if(i == sorhossz - 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            for (int k = 0; k < w-sorhossz-1; k++)
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
                    for (int j = 0; j < w-1; j++)
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

                string[,] matrix = new string[file[0].Length,file.Count()];
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
            Console.SetCursorPosition(Convert.ToInt32(w*0.05),Convert.ToInt32(h*0.95));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(szoveg);
        }
}
}
