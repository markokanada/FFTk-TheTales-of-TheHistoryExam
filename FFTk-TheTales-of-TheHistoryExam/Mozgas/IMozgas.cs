using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    interface IMozgas : IMMozgas
    {
        int Sebesseg { get; set; }
        void Balra();
        void Jobbra();
        void Le();
        void Fel();
        void Noveles(int mertek);
    }
}
