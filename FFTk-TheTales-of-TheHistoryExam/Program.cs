using System;
using System.IO;
using System.Text;
using System.Windows;

namespace FFTkTheTalesofTheHistoryExam
{
    class MainClass
    {
        public static void screenSizing()
        {
            double height = Console.LargestWindowHeight;
            double Width = Console.LargestWindowWidth;
            int maxheight = (int)Math.Round(Math.Floor(height));
            int maxWidth = (int)Math.Round(Math.Floor(Width));
            Console.SetWindowSize(maxheight,maxWidth);
            Console.WriteLine($"{maxWidth},{maxheight}");

        }

        public static string[] Reader(string cim) {
            StreamReader sr = new StreamReader($"{cim}.txt", Encoding.UTF8);
            int rowcount = File.ReadAllLines($"{cim}.txt").Length;
            string[] sorok = new string[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                sorok[i] = sr.ReadLine();
            }

            return sorok;

        }
        public static void Main(string[] args)
        {
            screenSizing();
            foreach (var item in Reader("brand"))
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
