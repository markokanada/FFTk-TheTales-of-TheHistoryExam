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
            //megjelenito.palyaMegjelenites("pálya1");
            //megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz");

            //Megjelenites megjelenito = new Megjelenites();
            //megjelenito.menuMegjelenites(0);

            //Mozgas mozgas = new Mozgas();

            //mozgas.MozgasAPalyan();

            Harc player = new Harc();
            SzobaFactory szoba = new SzobaFactory();
            Mentes mentes = new Mentes();
            Raktar raktar = new Raktar(5);
            raktar.TargyHozzadas("alma");
            raktar.TargyHozzadas("kés");
            raktar.TargyHozzadas("kulcs");
            raktar.TargyHozzadas("kenyér");
            raktar.TargyHozzadas("víz");

            Console.WriteLine(mentes.JatekMentes(raktar, player, szoba));
            Console.WriteLine(mentes.MentesTorles());



            Console.ReadKey();
        }
    }
}
