using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Raktar : IRaktar
    {
        public readonly List<string> felvehetoTargyak = new List<string>
        {
            "kard", "alma", "kenyér", "pénz", "gyűrű", "szövet", "kavics", "lapát", "cukor"
        };


        private int meret;
        public int Meret
        {
            get
            {
                return meret;
            }
            private set 
            {
                if (value > 0 && value <= 10)
                {
                    meret = value;
                }
                else
                {
                    meret = 5;
                }
            }
        }

        private string[] raktar;

        public bool RaktarMeretMegadasa(int meret)
        {
            Meret = meret;
            raktar = new string[Meret];

            if (raktar.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string[] RaktarLekerdezes()
        {
            return raktar;
        }

        public string[] TargyTorles(string targynev)
        {
            List<string> ideiglenesTorleshez = raktar.ToList();
            if (ideiglenesTorleshez.Contains(targynev) == true)
            {
                ideiglenesTorleshez.Remove(targynev);
                raktar = ideiglenesTorleshez.ToArray();
            }

            return raktar;
        }
        public string[] TargyHozzadas(string targynev) //ha null, akkor nincs hely egy új tárgynak
        {

            if (raktar.Length > raktar.Count(x => x != null))
            {
                //if (raktar.Contains(targynev) == true)
                //{
                //majd darab növelés a megadott tárgynál
                //}
                raktar[raktar.Count(x => x != null)] = targynev;
                
                return raktar;
            }
            else
            {
                return null;
            }
        }

        public void raktarInterakcio()
        {
            bool raktarRendezes = true;

            int raktarJelenlegiIndex = 0;
            while (raktarRendezes)
            {
                Console.Clear();

                string[] raktarTargyak = RaktarLekerdezes();

                int raktarMin = raktarTargyak.Length - raktarTargyak.Length;
                int raktarMax = raktarTargyak.Count(x => x != null);

                Console.WriteLine("--- RAKTÁR ---\n");

                Console.WriteLine($"\nSzabad helyek száma: {raktarTargyak.Length - raktarTargyak.Count(x => x != null)}\n");
                Console.WriteLine($"Tárgy törlése: [DEL]");

                if (raktarTargyak.Count(x => x != null) == 0)
                {
                    Console.WriteLine("[ÜRES]");
                }
                else
                {
                    for (int i = 0; i < raktarTargyak.Count(x => x != null); i++)
                    {
                        if (i == raktarJelenlegiIndex)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write(raktarTargyak[raktarJelenlegiIndex]);
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine(raktarTargyak[i]);
                        }
                    }
                }

                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (raktarJelenlegiIndex == raktarMax - 1)
                    {
                        raktarJelenlegiIndex = raktarMin;
                    }
                    else
                    {
                        raktarJelenlegiIndex++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (raktarJelenlegiIndex == raktarMin)
                    {
                        raktarJelenlegiIndex = raktarMax - 1;
                    }
                    else
                    {
                        raktarJelenlegiIndex--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Delete)
                {
                    TargyTorles(raktarTargyak[raktarJelenlegiIndex]);

                    if (raktarJelenlegiIndex > raktarMin)
                    {
                        raktarJelenlegiIndex--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Tab)
                {
                    raktarRendezes = false;
                }

                

            }
        }

        public Raktar(int meret)
        {
            RaktarMeretMegadasa(meret);
        }
    }
}
