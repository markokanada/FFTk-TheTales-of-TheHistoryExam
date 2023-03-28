using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    interface IMegjelenites
    {
        string KarakterNev { get; set; }
        string NPCNev { get; set; }
        string KarakterKep { get; set; }
        string NPCKep { get; set; }
        string Szoveg { get; set; }
        int ParbeszedIndex { get; set; }
    }
}
