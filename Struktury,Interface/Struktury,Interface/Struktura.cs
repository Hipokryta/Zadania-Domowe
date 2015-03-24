using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury_Interface
{
    public struct Zespolone
    {
        int czescRzeczywista, czescUrojona;

        public Zespolone(int czescRzeczywista, int czescUrojona)
        {
            this.czescRzeczywista = czescRzeczywista;
            this.czescUrojona = czescUrojona;

        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", czescRzeczywista, czescUrojona));
        }
        public static Zespolone operator +(Zespolone zespolona1, Zespolone zespolona2)
        {
            return new Zespolone(zespolona1.czescRzeczywista + zespolona2.czescRzeczywista, zespolona1.czescUrojona + zespolona2.czescUrojona);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Zespolone))
            {
                return false;
            }
            Zespolone liczbaZespolona = (Zespolone)obj;
            //dlaczego mialem blad przy obj as Zespolone
            bool porownanieCzesciUrojonej = liczbaZespolona.czescUrojona == czescUrojona;
            bool porownanieCzesciRzeczywistej = liczbaZespolona.czescRzeczywista == czescRzeczywista;

            if (porownanieCzesciUrojonej && porownanieCzesciRzeczywistej)
                return true;
            else
                return false;
        }
        


    }
}
