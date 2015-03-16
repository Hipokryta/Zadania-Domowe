using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tancerz kate = new Tancerz("Kate", "HIP-HOP", 5, "Blue");
            Tancerz kateSister = kate;
            Tancerz john = new Tancerz("John", "BreakDance", 5, "RED");

            
            Console.WriteLine(kateSister.ToString());
            Console.WriteLine(kate.Equals(kateSister));
            Console.WriteLine(Tancerz.iloscTancerzy);

            Console.WriteLine(john.ToString());
            john.specialMove();
            kate.specialMove(4);
            Console.Read();
        }
    }
}
