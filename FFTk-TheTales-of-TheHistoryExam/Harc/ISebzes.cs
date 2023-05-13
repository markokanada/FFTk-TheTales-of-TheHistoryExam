using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal interface ISebzes : IHarc
    {
        int Pancel { get;}
        int SebzesMertek { get;}
        bool Sebzes(Ellenfel ellenfel);
        bool Elpusztitas(Ellenfel ellenfel);
    }
}
