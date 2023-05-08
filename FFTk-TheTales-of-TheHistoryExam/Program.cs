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
            Mozgas mozgas = new Mozgas();

            string[,] ter = mozgas.Palya;
            
            for (int i = 0; i < ter.GetLength(0); i++)
            {
                for (int j = 0; j < ter.GetLength(1); j++)
                {
                    Console.Write(ter[i, j]);
                }
                Console.WriteLine();
            }


            //megjelenito.palyaMegjelenites("pálya1");
            //megjelenito.GombMegjelenites("[E] lenyomása az interakcióhoz");
            //megjelenito.menuMegjelenites(0);






            Console.ReadKey();
        }
    }
}
