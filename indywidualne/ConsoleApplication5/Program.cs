using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"~/../../../tancerze.txt"));
            List<string> values = new List<string>();
            

            Tancerz kate = new Tancerz("Kate", "HIP-HOP", 5, "Blue");
            Tancerz kateSister = kate;
            Tancerz john = new Tancerz("John", "BreakDance", 5, "RED");

//serializacja 
            Tancerz[] tancerze = new Tancerz[2];
            tancerze[0] = kate;
            tancerze[1] = john;
            SerializeToXML(tancerze);
            Tancerz[] loadedTancerze = Load(@"C:\tancerz.xml");
            foreach (var item in loadedTancerze)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(kateSister.ToString());
            Console.WriteLine(kate.Equals(kateSister));
            //Console.WriteLine(Tancerz.iloscTancerzy);

            Console.WriteLine(john.ToString());
            john.specialMove();
            kate.specialMove(4);
            Console.Read();
        }
        static public void SerializeToXML(Tancerz[] tancerz)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Tancerz[]));
            TextWriter textWriter = new StreamWriter(@"C:\tancerz.xml");
            serializer.Serialize(textWriter, tancerz);
            textWriter.Close();
        }
        static public Tancerz[] Load(string path)
        {
            var serializer = new XmlSerializer(typeof(Tancerz[]));
            using (var stream = new FileStream(path, FileMode.Open))
            {
                return serializer.Deserialize(stream) as Tancerz[];
            }
        }
    }
}
