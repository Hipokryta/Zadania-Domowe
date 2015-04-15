using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            NapojeBezalkoholowe n1 = new NapojeBezalkoholowe("IceTea", 1200, 400, 3000);
            NapojeBezalkoholowe n2 = new NapojeBezalkoholowe("Soczek", 120, 300, 100);
            NapojeBezalkoholowe n3 = new NapojeBezalkoholowe("jogurt", 500, 700, 800);
            NapojeBezalkoholowe n7 = new NapojeBezalkoholowe(n2);
            n1.cena = 60000;

            Energetyki n4 = new Energetyki("Monster", 500, 700, 800, 4333, 22);
            Energetyki n5 = new Energetyki("burn", 700, 860, 80, 433, 220);

            NapojeBezalkoholowe[] napBezLista = new NapojeBezalkoholowe[4];
            Energetyki[] napEnergLista = new Energetyki[2];

            napBezLista[0] = n1;
            napBezLista[1] = n2;
            napBezLista[2] = n3;
            napBezLista[3] = n7;

            napEnergLista[0] = n4;
            napEnergLista[1] = n5;

            foreach (NapojeBezalkoholowe item in napBezLista)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Energetyki");

            foreach (Energetyki item in napEnergLista)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Liczba napoi " + NapojeBezalkoholowe.liczbaNapoi);
            Console.WriteLine();

            Console.WriteLine(n2.Equals(n7));//true
            Console.WriteLine(n2.Equals(n1));//false
            Console.WriteLine();

            Console.WriteLine("Cena");
            Console.WriteLine(n2 + n3);//1000
            Console.WriteLine(n1 + n2);//700
            Console.WriteLine();

            List<NapojeBezalkoholowe> listaNapojow = new List<NapojeBezalkoholowe>();
            foreach (var item in napBezLista)
            {
                listaNapojow.Add(item);

            }

            listaNapojow.Sort();
            foreach (NapojeBezalkoholowe item in listaNapojow)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            NapojeBezalkoholowe.pokazNapojePowyzejStu();
            Console.ReadKey();

        }
    }
    class NapojeBezalkoholowe : IComparable
    {
        public string nazwa;
        public int pojemnosc, cenaWGroszach, kalorycznosc;
        public static int liczbaNapoi;
        public static List<string> napojWiecejNizSto = new List<string>();

        public int cena
        {
            get { return cenaWGroszach; }
            set { cenaWGroszach = value; }
        }
        static NapojeBezalkoholowe()
        {
            liczbaNapoi = 0;
        }

        public NapojeBezalkoholowe(string nazwa, int pojemnosc, int cenaWGroszach, int kalorycznosc)
        {
            this.nazwa = nazwa;
            this.pojemnosc = pojemnosc;
            this.cenaWGroszach = cenaWGroszach;
            this.kalorycznosc = kalorycznosc;
            liczbaNapoi++;
            if (this.obliczKalorycznosc() > 100)
            {
                napojWiecejNizSto.Add(nazwa);
            }
        }

        public NapojeBezalkoholowe(NapojeBezalkoholowe nowyNapoj)
        {
            this.nazwa = nowyNapoj.nazwa;
            this.pojemnosc = nowyNapoj.pojemnosc;
            this.cenaWGroszach = nowyNapoj.cenaWGroszach;
            this.kalorycznosc = nowyNapoj.kalorycznosc;
            liczbaNapoi++;

        }
        public override string ToString()
        {
            return "nazwa: " + nazwa + " pojemnosc " + pojemnosc + "ml cena " + cena + "gr kalorycznosc na 100ml " + obliczKalorycznosc();

        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            NapojeBezalkoholowe napoj2 = obj as NapojeBezalkoholowe;
            if ((System.Object)napoj2 == null)
            {
                return false;
            }

            return napoj2.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return pojemnosc * 9 / kalorycznosc;
        }
        public virtual double obliczKalorycznosc()
        {
            return (kalorycznosc * 100) / pojemnosc;
        }
        public static int operator +(NapojeBezalkoholowe A, NapojeBezalkoholowe B)
        {
            return A.cenaWGroszach + B.cenaWGroszach;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            NapojeBezalkoholowe napoj = obj as NapojeBezalkoholowe;
            if (napoj != null)
                return this.cena.CompareTo(napoj.cena);
            else
                throw new NotImplementedException();
        }
        public static void pokazNapojePowyzejStu()
        {
            foreach (var item in napojWiecejNizSto)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Energetyki : NapojeBezalkoholowe
    {
        int zawartoscKofeiny, zawartoscTauryny;
        public Energetyki(string nazwa, int pojemnosc, int cenaWGroszach, int kalorycznosc, int zawartoscKofeiny, int zawartoscTauryny)
            : base(nazwa, pojemnosc, cenaWGroszach, kalorycznosc)
        {
            this.zawartoscKofeiny = zawartoscKofeiny;
            this.zawartoscTauryny = zawartoscTauryny;

        }
        public override string ToString()
        {
            return "nazwa: " + nazwa + " pojemnosc " + pojemnosc + "ml cena " + cena + "gr kalorycznosc na 100ml " + obliczKalorycznosc() + " ilosc kofeiny " + zawartoscKofeiny + " ilosc tauryny " + zawartoscTauryny;

        }

        public override double obliczKalorycznosc()
        {
            return (zawartoscKofeiny * 100) / pojemnosc;
        }

    }
}
