using FFTkTheTalesofTheHistoryExam.Szoba;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace FFTkTheTalesofTheHistoryExam
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Megjelenites megjelenito = new Megjelenites();
            //megjelenito.palyaMegjelenites("pálya1");
            //megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz");


            megjelenito.menuMegjelenites(0);

            //Mozgas mozgas = new Mozgas();

            //mozgas.MozgasAPalyan();

            //Harc player = new Harc();
            //SzobaFactory szoba = new SzobaFactory();
            //Mentes mentes = new Mentes();
            //Raktar raktar = new Raktar(5);

            //Console.WriteLine(mentes.JatekMentes(raktar, player, szoba));
            //Console.WriteLine(mentes.MentesTorles());

            
            //Console.WriteLine(kviz.Pont());

            Console.ReadKey();
        }
    }
}
