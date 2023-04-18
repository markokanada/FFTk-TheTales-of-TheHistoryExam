using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal interface ISebzes : IHarc
    {
        int Pancel { get; set; }
        int SebzesMertek { get; set; }
        void Sebzes();
        void Elpusztitas();
    }
}
