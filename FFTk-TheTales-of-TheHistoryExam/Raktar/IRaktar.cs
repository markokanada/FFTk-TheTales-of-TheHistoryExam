using System;
namespace FFTkTheTalesofTheHistoryExam
{
    public interface IRaktar
    {
        string[] RaktarLekerdezes();
        string[] TargyTorles(string targynev);
        string[] TargyHozzadas(string targynev);
        int Meret { get; }
    }
}
