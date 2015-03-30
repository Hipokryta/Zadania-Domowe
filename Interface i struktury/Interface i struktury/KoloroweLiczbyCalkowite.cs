using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_i_struktury
{
    class KoloroweLiczbyCalkowite : IComparable
    {
        private int liczba;
        private string kolor;

        public KoloroweLiczbyCalkowite(int liczba,string kolor)
        {
            this.liczba = liczba;
            this.kolor = kolor;
        }
        public override string ToString()
        {
            return liczba+" "+kolor;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            KoloroweLiczbyCalkowite otherTemperature = obj as KoloroweLiczbyCalkowite;
            if (otherTemperature != null)
                return this.liczba.CompareTo(otherTemperature.liczba);
            else
            throw new NotImplementedException();
        }


  
    }
}
