using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    interface IMegjelenit : IKKuldetes
    {
        string Nev { get; set; }
        string Leiras { get; set; }
        int Index { get; set; }
    }
}
