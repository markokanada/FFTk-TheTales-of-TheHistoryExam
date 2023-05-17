using FFTkTheTalesofTheHistoryExam.Szoba;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Mentes : IMentes
    {

        public bool JatekMentes(Raktar raktar, Harc jatekos, SzobaFactory szoba)
        {
            DirectoryInfo mentesiFajlok = new DirectoryInfo("Mentesek/");

            // Mappa tartalmának lekérése
            FileInfo[] fajlok = mentesiFajlok.GetFiles();

            if (fajlok.Length == 0)
            {
                Console.WriteLine("Még nincsen egy mentésed sem");
            }
            else
            {
                // Fájlok kiíratása
                Console.WriteLine("Eddigi mentéseid: ");
                int fajlIndex = 1;
                foreach (FileInfo fajl in fajlok)
                {
                    Console.WriteLine($"{fajlIndex} - {fajl}");
                    fajlIndex++;
                }
            }
           

            Console.Write("Add meg a mentés nevét: ");
            string mentesNev = Console.ReadLine();

            if ( mentesNev.Length > 0)
            {
                foreach (FileInfo fajl in fajlok)
                {
                    if (fajl.Name == $"{mentesNev}.txt")
                    {
                        Console.Write("Már van ilyen nevű mentésed, biztosan felül szeretnéd írni ? I/N : ");
                        string dontes = Console.ReadLine();

                        if (dontes == "I")
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }


                StreamWriter sw = new StreamWriter($"Mentesek/{mentesNev}.txt", false, Encoding.UTF8);

                string menteniValoDolgok = $"RaktarMeret:{raktar.Meret}\n" +
                                           $"Raktar:{String.Join(";", raktar.RaktarLekerdezes())}\n" +
                                           $"Elet:{jatekos.Elet}\n" +
                                           $"Pont:{jatekos.Pont}\n" +
                                           $"SebzesMertek:{jatekos.SebzesMertek}\n" +
                                           $"VedelemMertek:{jatekos.VedelemMertek}\n" +
                                           $"Pancel:{jatekos.Pancel}\n" +
                                           $"SzobaId:{szoba.Id}";

                sw.WriteLine(menteniValoDolgok);
                sw.Close();
                return true;


            }
            else
            {
                return false;
            }
            
        }

        public bool MentesTorles()
        {
            DirectoryInfo mentesiFajlok = new DirectoryInfo("Mentesek/");

            // Mappa tartalmának lekérése
            FileInfo[] fajlok = mentesiFajlok.GetFiles();

            // Fájlok kiíratása
            int fajlIndex = 1;
            foreach (FileInfo fajl in fajlok)
            {
                Console.WriteLine($"{fajlIndex} - {fajl}");
                fajlIndex++;
            }
            int eredetiMeret = fajlok.Length;


            Console.Write("Melyik fájl szeretnéd törölni: ");
            int torlesIndex = int.Parse(Console.ReadLine());
            if (torlesIndex > 0 && torlesIndex < eredetiMeret)
            {
                FileInfo torlesFajlNeve = fajlok[torlesIndex - 1];
                File.Delete($"Mentesek/{torlesFajlNeve}");

                fajlok = mentesiFajlok.GetFiles();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
