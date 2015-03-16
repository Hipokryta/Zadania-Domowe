using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Pracownik
    {
        int IdPrac;
        string Nazwisko;
        string Imie;
        string Email;
        static int ilosc = 0;
        public Pracownik(int IdP, string Naz)
        {
            IdPrac = IdP;
            Nazwisko = Naz;
            ilosc++;
        }
        public Pracownik(int IdP, string Naz, string Im, string Em)
            : this(IdP, Naz)
        {
            Imie = Im;
            Email = Em;
            
        }
        public Pracownik(Pracownik p1)
        {
            IdPrac = p1.IdPrac;
            Imie = p1.Imie;
        }
        /*public void PokazPrac()
        {
            Console.WriteLine("{0} {1} {2} {3}", IdPrac, Nazwisko, Imie, Email);
        }*/
        public override string ToString()
        {
            return IdPrac+" "+ Nazwisko+" "+Imie+" "+Email;
            
        }
        public static int ile()
        {
            return ilosc;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Pracownik p = obj as Pracownik;
            if ((System.Object)p == null)
            {
                return false;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();

        }
    }
}
