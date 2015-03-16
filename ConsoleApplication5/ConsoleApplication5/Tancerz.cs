using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication5
{
    class Tancerz
    {
        public static int iloscTancerzy;
        int poziomUmiejetnosci;
        String stylTanca, imie;
        String kolor;
        
        static Tancerz()
        {
            iloscTancerzy = 0;
        }
        public Tancerz(String imie,String stylTanca, int poziomUmiejetnosci, String kolor)
        {
            this.poziomUmiejetnosci = poziomUmiejetnosci;
            this.imie = imie;
            this.stylTanca = stylTanca;
            this.kolor = kolor;
            iloscTancerzy++;
        }
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Tancerz tancerz2 = obj as Tancerz;
            if ((System.Object)tancerz2 == null)
            {
                return false;
            }

            return tancerz2.poziomUmiejetnosci == this.poziomUmiejetnosci ;
        }

        public override string ToString()
        {
            drawCharacter();
            return "Tancerz: " +imie + " \nStyl: " + stylTanca + "\nPoziom Mocy: " + poziomUmiejetnosci;
        }
        public override int GetHashCode()
        {
            return poziomUmiejetnosci*9;
        }
        public void drawCharacter()
        {
            ConsoleColor wybranykolor;
            if (kolor == "RED")
            {
                wybranykolor = ConsoleColor.Red;
            }
            else
            {
                wybranykolor = ConsoleColor.Blue;
            }
            //glowa
            for (int i = 0; i < 4; i++)
            {
                Console.Write("     ");
                Console.BackgroundColor = wybranykolor;

                Console.Write("       ");
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.Write("       ");
            Console.BackgroundColor = wybranykolor;
            Console.Write("  ");
            Console.ResetColor();
            Console.WriteLine();
            //rece
            Console.Write("   ");
            Console.BackgroundColor = wybranykolor;

            Console.Write("           ");
            Console.ResetColor();
            Console.WriteLine();

             Console.Write("     ");
             Console.BackgroundColor = wybranykolor;

                Console.Write("       ");
                Console.ResetColor();
                Console.WriteLine();

             Console.Write("     ");
             Console.BackgroundColor = wybranykolor;

                Console.Write("   ");
                Console.ResetColor();
                Console.Write(" ");
                Console.BackgroundColor = wybranykolor;

                Console.Write("   ");
                Console.WriteLine();
                Console.ResetColor();
            
        }

        public void specialMove()
        {
            Console.WriteLine(imie+" uzywa specjalnego ruchu");
        }
        public void specialMove(int czas)
        {
            for (int i = 1; i <= czas; i++)
            {
                Console.WriteLine(imie+" uzywa specjalnego ruchu X"+i+" razy");
            }
            
        }
    }
}
