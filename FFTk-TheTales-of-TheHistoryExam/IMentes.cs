using FFTkTheTalesofTheHistoryExam.Szoba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal interface IMentes
    {
        bool JatekMentes(Raktar raktar, Harc jatekos, SzobaFactory szoba);
        bool MentesTorles();
    }
}
