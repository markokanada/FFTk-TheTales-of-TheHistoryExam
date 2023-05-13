using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace FFTkTheTalesofTheHistoryExam
{
    internal class Harc : ISebzes, IGyogyulas, IVedelem
    {
        private int pont;
        public int Pont
        {
            get { return pont; }
            private set { pont = value; }
        }

        public Harc()
        {
            Random random = new Random();

            Elet = 100;
            SebzesMertek = random.Next(10, 16);
            VedelemMertek = random.Next(1, 11);
            Pont = 0;
            //GyogyulasMerteke = 20;
            Pancel = 50;
        }

        private int elet;
        public int Elet
        {
            get { return elet; }
            set { elet = value; }
        }

        private int sebzes;
        public int SebzesMertek
        {
            get { return sebzes; }
            set { sebzes = value; }
        }
        private int vedelem;
        public int VedelemMertek
        {
            get { return vedelem; }
            set { vedelem = value; }
        }

        public void Harcolas(Ellenfel ellenfel)
        {
            Console.WriteLine("\t-----A harc elkezdődik!-----\n\n");


            while (Elet > 0 && ellenfel.Elet > 0)
            {
                Thread.Sleep(1000);
                //player támad
                if (Elet > 0)
                {
                    if (Sebzes(ellenfel))
                    {
                        int dmg = SebzesMertek - ellenfel.VedelemMertek;
                        Console.WriteLine("\t***\tTe támadsz !\t***");
                        Console.WriteLine($"\n\t\tTámadás:  {dmg}dmg");

                        if (ellenfel.Pancel > 0)
                        {
                            if (dmg > ellenfel.Pancel)
                            {
                                dmg -= ellenfel.Pancel;
                                ellenfel.Pancel = 0;
                                ellenfel.Elet -= dmg;
                                Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Pancel} armor");
                                Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Elet} hp");
                            }
                            else
                            {
                                ellenfel.Pancel -= dmg;
                                Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Pancel} armor");
                                Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Elet} hp");
                            }

                        }
                        else
                        {
                            ellenfel.Elet -= dmg;
                            Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Pancel} armor");
                            Console.WriteLine($" \n\t\tEllenfél: {ellenfel.Elet} hp");
                        }
                        
                        
                        
                        
                        
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\t***\tA támadásod sikertelen volt !\t***\n");
                    }
                    
                }

                //Thread.Sleep(1000);

                //enemy támad

                if (ellenfel.Elet > 0)
                {
                    if (ellenfel.Sebzes())
                    {
                        int dmg = ellenfel.SebzesMertek - VedelemMertek;
                        Console.WriteLine("\t***\tAz ellenfél támad !\t***");
                        Console.WriteLine($"\n\t\tTámadás:  {dmg}dmg");

                        if (Pancel > 0)
                        {
                            if (dmg > Pancel)
                            {
                                dmg -= Pancel;
                                Pancel = 0;
                                Elet -= dmg;
                                Console.WriteLine($" \n\t\tTe: {Pancel} armor");
                                Console.WriteLine($"\n\t\tTe: {Elet} hp");
                            }
                            else
                            {
                                Pancel -= dmg;
                                Console.WriteLine($" \n\t\tTe: {Pancel} armor");
                                Console.WriteLine($"\n\t\tTe: {Elet} hp");
                            }


                        }
                        else
                        {
                            Elet -= dmg;
                            Console.WriteLine($" \n\t\tTe: {Pancel} armor");
                            Console.WriteLine($"\n\t\tTe: {Elet} hp");
                        }

                        
                        
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("\t***\tAz ellenfél támadása sikertelen volt !\t***\n");
                    }

                }

            }

            if (Elet > 0)
            {
                Console.Write("\t\t");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Nyertél!");
                Console.ResetColor();
                Console.WriteLine();
                Pont += 1;
            }
            else
            {
                Console.Write("\t\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Vesztettél!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private int pancel;
        public int Pancel
        {
            get { return pancel; }
            private set
            {
                pancel = value;
            }
        }

        private int gyogyulasMerteke;
        public int GyogyulasMerteke
        {
            get { return gyogyulasMerteke; }
            private set
            {
                if (value > 0 && value <= 40)
                {
                    gyogyulasMerteke = value;
                }
                else
                {
                    gyogyulasMerteke = 20;
                }
            }
        }




        public bool Elpusztitas(Ellenfel ellenfel) //sikeres vagy nem
        {
            if (ellenfel.Elet <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Gyogyulas() //gyógyulás mértéke
        {
            Elet += GyogyulasMerteke;
            return GyogyulasMerteke;
        }

        public bool Sebzes(Ellenfel ellenfel) //sikeres vagy nem
        {
            if (ellenfel.Vedes())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Vedes() //sikeres vagy nem
        {
            Random random = new Random();

            int veletlenszam = random.Next(1, 10 + 1);
            Console.WriteLine(veletlenszam);
            if ( veletlenszam == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
