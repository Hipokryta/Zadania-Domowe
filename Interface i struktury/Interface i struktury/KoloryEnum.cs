using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_i_struktury
{
    class KoloryEnum : IEnumerator
    {
        public String[] kolory;
        public int position = -1;
        public KoloryEnum(string[] list)
        {
            kolory = list;
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public string Current
        {
            get
            {
                try
                {
                    return kolory[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        bool IEnumerator.MoveNext()
        {
            position++;
            return (position < kolory.Length);
        }

        void IEnumerator.Reset()
        {
            return ;
        }
    }
}
