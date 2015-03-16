using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Macierz
    {
        public int kolumny { get; set; }
        public int wiersze { get; set; }
        public int[,] macierz { get; set; }
        public Macierz(int wiersze, int kolumny)
        {
            this.wiersze = wiersze;
            this.kolumny = kolumny;
        }
        public Macierz(int wiersze, int kolumny, int[,] macierz)
            : this(wiersze, kolumny)
        {
            this.macierz = macierz;
        }
        public override bool Equals(System.Object obj)
        {

            Macierz macierzY = obj as Macierz;
            if (macierzY.macierz == null)
            {
                Console.WriteLine("Nie sa rowne");
                return false;
            }

            bool SizeIsEqual =  (kolumny == macierzY.kolumny && wiersze == macierzY.wiersze);
            if (SizeIsEqual)
            {
                for (int i = 0; i < wiersze; i++)
                {
                    for (int j = 0; j < kolumny; j++)
                    {
                        if (macierz[i, j] != macierzY.macierz[i, j])
                        {
                            Console.WriteLine("Nie sa rowne");
                            return false;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ZLY WYMIAR");
                return false;
            }
            Console.WriteLine("Sa rowne");
            return true;
        }
        public override string ToString()
        {
            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    Console.Write(macierz[i,j]+" ");
                }
                Console.WriteLine();
            }
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return wiersze ^ kolumny;

        }
        public void dodajMacierze(int[,] macierzY)
        {
            bool SizeIsEqual = ReferenceEquals(macierz, macierzY);
            if (SizeIsEqual)
            {
                for (int i = 0; i < wiersze; i++)
                {
                    for (int j = 0; j < kolumny; j++)
                    {
                        Console.Write(macierz[i, j] + macierzY[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static Macierz operator +(Macierz A, Macierz B)
        {
            int[,]wartosciMacierzy = new int[A.wiersze,A.kolumny] ;
            bool SizeIsEqual = ReferenceEquals(A, B);
            if (SizeIsEqual)
            {
 

                for (int i = 0; i < A.wiersze; i++)
                {
                    for (int j = 0; j < A.kolumny; j++)
                    {
                        wartosciMacierzy[i, j] = wartosciMacierzy[i, j] + A.macierz[i, j] + B.macierz[i, j];
                        Console.Write(A.macierz[i,j] + B.macierz[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }
            Macierz macierzWynikowa = new Macierz(A.wiersze, A.kolumny, wartosciMacierzy);
            return macierzWynikowa;
        }

        public static Macierz operator *(Macierz A, Macierz B)
        {
            int[,] wartosciMacierzy = new int[A.wiersze, A.kolumny];
            bool SizeIsEqual = ReferenceEquals(A, B);
            if (SizeIsEqual)
            {


                for (int i = 0; i < A.wiersze; i++)
                {
                    for (int j = 0; j < A.kolumny; j++)
                    {
                        int pomonozone = A.macierz[i, j] * B.macierz[i, j];
                        wartosciMacierzy[i, j] = wartosciMacierzy[i, j] + pomonozone;
                    }
                }
            }
            Macierz macierzWynikowa = new Macierz(A.wiersze, A.kolumny, wartosciMacierzy);
            return macierzWynikowa;
        }
        public void maxMacierz4x4(ref int wiersz, ref int kolumna)
        {
            int najwiekszaSuma = 0;
            for (int i = 0; i <= wiersze; i++)
            {
                for (int j = 0; j <= kolumny; j++)
                {
                    //System.IndexOutOfRangeException handler
                    if ((j  < (kolumny -1))&&(i < (wiersze-1)))
                    {
                        int suma = macierz[i, j] + macierz[i + 1, j] + macierz[i + 1, j + 1] + macierz[i, j + 1];
                        if (suma > najwiekszaSuma)
                        {
                            wiersz = i;
                            kolumna = j;
                        }
                    }
                }
            }
        }

    }
}
