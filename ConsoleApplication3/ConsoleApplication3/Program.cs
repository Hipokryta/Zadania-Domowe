using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik(23,"ffff","dw","feeeeeeee");
            Pracownik p2 = new Pracownik(35, "rwwww");

            Console.WriteLine("Ilosc pracownikow");
            Console.WriteLine(Pracownik.ile());
            

            Macierz m1 = new Macierz(4, 2,new int[,]{ { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
            Macierz m2 = new Macierz(4, 2, new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
            Macierz m3 = new Macierz(4, 3, new int[,] { { 1, 2,3 }, { 3, 4,5 }, { 5, 6,7 }, { 7, 8,9 } });

            Console.WriteLine("Sprawdza czy sa rowne");
            m1.Equals(m2);
            Console.WriteLine("WYSWIETL MACIERZ");
            m1.ToString();
            Console.WriteLine("DODANE MACIERZE");
            m1.dodajMacierze(m1.macierz);
            Console.WriteLine("POMNOZONE MACIERZE");
            Console.WriteLine(m1*m1);
            int kolumna = 0, wiersz = 0;
            Console.WriteLine("MAX MACIERZ");
            m3.maxMacierz4x4(ref wiersz,ref kolumna);
            Console.WriteLine("wiersz: "+wiersz+" kolumna: "+kolumna);
            Console.ReadKey();
/* Baza danych
            SqlConnection connection = new SqlConnection("Server=MININT-O167DCM\\MSSQLSERVER2;Database=AdventureWorks2014;Integrated Security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Person.Person", connection);
            SqlDataReader reader = cmd.ExecuteReader();
          while (reader.Read())
            {
                Console.WriteLine("{1} {0}", reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            connection.Close();

            
// Entinity Framework
            using (var ctx = new AdventureWorks2014Entities())
            {

                Console.WriteLine("Find Student");
                var std1 = ctx.People.Find(1);

                Console.WriteLine("Context tracking changes of {0} entity.", ctx.ChangeTracker.Entries().Count());
                Console.WriteLine("dupa");
                DisplayTrackedEntities(ctx.ChangeTracker);
                
            }
            Console.ReadKey();
        }

        private static void DisplayTrackedEntities(DbChangeTracker changeTracker)
        {
            Console.WriteLine("");

            var entries = changeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                Console.WriteLine("Status: {0}", entry.State);
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");*/
        }
    }
}
