using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTkTheTalesofTheHistoryExam
{
    internal class Harc : ISebzes, IGyogyulas, IVedelem
    {
        public int Elet { get; private set; }

        public int Pancel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SebzesMertek { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GyogyulasMerteke { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VedelemMertek { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Elpusztitas()
        {
            throw new NotImplementedException();
        }

        public void Gyogyulas()
        {
            throw new NotImplementedException();
        }

        public void Sebzes()
        {
            throw new NotImplementedException();
        }

        public void Vedes()
        {
            throw new NotImplementedException();
        }
    }
}
