using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        public static Dictionary<char, int> letters = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            string longText = System.IO.File.ReadAllText(@"~/../../../TextFile1.txt");

        var count = CharacterCount.Count(longText);

        foreach (var character in count)
        {
            Console.WriteLine("{0} - {1}", character.Key, character.Value);
        }
        foreach (KeyValuePair<char, ulong> author in count.OrderBy(key => key.Value))
        { 
            Console.WriteLine("Key: {0} Value: {1}", author.Key, author.Value);
        }
        Film f1 = new Film(12,"komp","niado poak",1332,43);
        Film f2 = new Film(144, "koap", "zartow ptak", 865, 09);
        Film[] f1i2 = new Film[2];
        f1i2[0] = f1;
        f1i2[1] = f2;
        SerializeToXML(f1i2);
        Film[] loaded = Load(@"C:\movie.xml");
        foreach (var item in loaded)
        {
            Console.WriteLine("{0}, {1}, {2}",item.Id,item.Title,item.Name);
        }
       }
        static public void SerializeToXML(Film[] movie)
        {
          XmlSerializer serializer = new XmlSerializer(typeof(Film[]));
          TextWriter textWriter = new StreamWriter(@"C:\movie.xml");
          serializer.Serialize(textWriter, movie);
          textWriter.Close();
        }
        static public Film[] Load(string path)
        {
            var serializer = new XmlSerializer(typeof(Film[]));
            using (var stream = new FileStream(path, FileMode.Open))
            {
                return serializer.Deserialize(stream) as Film[];
            }
        }
        
    }

    class CharacterCount 
    {
        public static SortedDictionary<char, ulong> Count(string stringToCount)
        {
            SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();

            foreach (var character in stringToCount)
            {
             
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
        }

       


    }

        
    }

