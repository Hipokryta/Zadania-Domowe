using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Interface_i_struktury
{
    //public class Kolory : //IEnumerable<string>
    //{ 
    //    private string[] tab = new string[6];
    //    int ile = 0;
    //    public Kolory(params string[] TabParam)
    //    {
    //        foreach (string txt in TabParam)
    //        {
    //            tab[ile++] = txt;
    //        }
    //    }


    //}
    class Kolory: IEnumerable<string>
    {
        private string[] tab = new string[6];
        int ile = 0;
        public Kolory(params string[] items)
        {
            foreach (var item in items) 
            {
                tab[ile++] = item;
            }
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            foreach (string datum in tab)
            {
                yield return datum;
            }
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
