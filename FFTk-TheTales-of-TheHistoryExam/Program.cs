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
            Ellenfel enemy = new Ellenfel();
            Ellenfel enemy2 = new Ellenfel();

            player.Harcolas(enemy);
            player.Harcolas(enemy2);



            Console.ReadKey();
        }
    }
}
