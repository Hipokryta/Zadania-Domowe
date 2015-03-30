using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_i_struktury
{
    class Program
    {
        static void Main(string[] args)
        {
//zad 1
            List<KoloroweLiczbyCalkowite> mojaLista = new List<KoloroweLiczbyCalkowite>();
            Random random = new Random();
            string[] kolory = { "biały", "czerwony", "żółty", "zielony", "czarny", "brązowy" };
            foreach (var kolor in kolory)
            {
                int liczba = random.Next(0, 20);
                mojaLista.Add(new KoloroweLiczbyCalkowite(liczba,kolor));

            }
//zad 2
            mojaLista.Sort();
            foreach (var item in mojaLista)
	        {
		        Console.WriteLine(item.ToString());
	        }

// zad 3 

            Kolory k = new Kolory("biały", "czerwony", "żółty", "zielony", "czarny", "brązowy");
            foreach (string kolor in k)
            {
                System.Console.WriteLine("Kolory: {0}", kolor);
            }
//zad 4
            string[] tab ={"2 trefl","3 trefl","4 trefl","5 trefl","6 trefl","7 trefl","8 trefl","9 trefl","10 trefl","Walet trefl","Dama trefl","Kr�l trefl","As trefl",
				   "2 pik","3 pik","4 pik","5 pik","6 pik","7 pik","8 pik","9 pik","10 pik","Walet pik","Dama pik","Kr�l pik","As pik",
				   "2 karo","3 karo","4 karo","5 karo","6 karo","7 karo","8 karo","9 karo","10 karo","Walet karo","Dama karo","Kr�l karo","As karo",
				   "2 kier","3 kier","4 kier","5 kier","6 kier","7 kier","8 kier","9 kier","10 kier","Walet kier","Dama kier","Kr�l kier","As kier"};
            List<string> talia = new List<string>();    // deklaracja listy
            for (int i = 0; i < tab.Length; i++)        // wypelnienie listy kartami (przed tasowaniem)
                talia.Add(tab[i]);

            Random r1 = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                int num1 = r1.Next(0, tab.Length-1);
                String result = talia[i];
                talia[i] = talia[num1];
                talia[num1] = result;
            }

            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(talia[i]);

            Console.ReadKey();



        }
    }
}
