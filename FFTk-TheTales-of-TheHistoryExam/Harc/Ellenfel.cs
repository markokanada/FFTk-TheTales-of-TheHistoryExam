using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Ellenfel
    {

        public Ellenfel()
        {
            Random random = new Random();

            Elet = 50;
            SebzesMertek = random.Next(10, 16);
            VedelemMertek = random.Next(1, 6);
            Pancel = 15;
        }

        private int elet;
        public int Elet
        {
            get { return elet; }
            set { elet = value; }
        }

        private int sebzes;
        public int SebzesMertek
        {
            get { return sebzes; }
            set { sebzes = value; }
        }
        private int vedelem;
        public int VedelemMertek
        {
            get { return vedelem; }
            set { vedelem = value; }
        }

        private int pancel;
        public int Pancel
        {
            get { return pancel; }
            set
            {
                pancel = value;
            }
        }

        public bool Sebzes() //sikeres vagy nem
        {
            if (Vedes())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Vedes() //sikeres vagy nem
        {
            Random random = new Random();
            Thread.Sleep(10);
            int veletlenszam = random.Next(1, 10 + 1);
            if (veletlenszam == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
