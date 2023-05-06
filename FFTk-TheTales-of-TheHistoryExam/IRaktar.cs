using System;
namespace FFTkTheTalesofTheHistoryExam
{
    public interface IRaktar
    {
        string[] RaktarLekerdezes();
        string[] TargyTorles(string targynev);
        string[] TargyHozzadas(string targynev);
        string JelenlegiTargy { get; }
        string ElozoTargy { get; }
        string KovetkezoTargy { get; }
        int JelenlegiTargyIndex { get; }
        int Meret { get; }
    }
}
