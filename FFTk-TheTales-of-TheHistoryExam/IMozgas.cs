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
        void Balra(int lepes);
        void Jobbra(int lepes);
        void Le(int lepes);
        void Fel(int lepes);
        void Noveles(int mertek);
    }
}
