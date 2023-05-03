using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam.Szoba
{
    internal interface ISzobaFactory : ISzoba
    {
        ISzoba Letrehoz(int fileSor);
    }
}
