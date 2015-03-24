using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------ Test interfejsu -------");
            //Pracownik p1 = new Pracownik("Kowalski", "Jan", new DateTime(1980, 7, 28));
            //Console.WriteLine("Wiek {0}", p1.Wiek());

            Console.WriteLine(Puzzle("a Aad")); 

            Console.ReadKey();
        }
        public static string Puzzle(string s)
        {
            try
            {
                int pominietePierwszeSlowo = s.IndexOf(" ");
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                return "";
            }
            s.Substring(s.IndexOf(" "));
            foreach (char i in s)
            {
                if (Char.IsUpper(i))
                    s.Remove(s.IndexOf(i), 1);
            }
            return s;
        }
    }
}
