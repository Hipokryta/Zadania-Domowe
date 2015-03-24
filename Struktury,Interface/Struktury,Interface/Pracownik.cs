using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury_Interface
{
    public class Pracownik : IOsoba, IAdres
    {
        private string Nazwisko;
        private string Imie;
        private DateTime DataUrodzenia;

        public Pracownik(string n, string i, DateTime d)
        {
            Nazwisko = n;
            Imie = i;
            DataUrodzenia = d;
        }
        public int Wiek()
        {
            return (DateTime.Now.Year - this.DataUrodzenia.Year);
        }
        public override bool Equals(object obj)
        {
            Pracownik pracownik = (Pracownik)obj;
            if((pracownik.DataUrodzenia==DataUrodzenia)
             &&(pracownik.Imie==Imie)
             && (pracownik.Nazwisko == Nazwisko))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}, {2}",Imie,Nazwisko,DataUrodzenia);
        }

        public string Ulica
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Kod
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
