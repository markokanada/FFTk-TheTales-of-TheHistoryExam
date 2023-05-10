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
            SebzesMertek = random.Next(15, 21);
            VedelemMertek = random.Next(1, 6);
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
    }
}
