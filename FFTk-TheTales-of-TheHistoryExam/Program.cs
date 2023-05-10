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
            megjelenito.palyaMegjelenites("pálya1");
            megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz", 0, 0);
            //megjelenito.menuMegjelenites(0);
            Mozgas mozgas = new Mozgas();

            mozgas.MozgasAPalyan();

            //Harc player = new Harc
            //{
            //    Elet = 100,
            //    SebzesMertek = 10,
            //    VedelemMertek = 5
            //};
            //Ellenfel enemy = new Ellenfel
            //{
            //    Elet = 80,
            //    SebzesMertek = 8,
            //    VedelemMertek = 3
            //};

            //player.Fight(enemy);


            Console.ReadKey();
        }
    }
}
