using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using di = System.IO.Directory;
namespace pliki
{
    class Program
    {
        public static Object displayPath(string path, int row)
        { 
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            string blankSpace = "  ";
            string blankSpaceWithRow="";
            for (int i = 0; i < row; i++)
            {
                blankSpaceWithRow=blankSpaceWithRow+blankSpace;
            }

            
            FileInfo[] fileNames = dirInfo.GetFiles("*");
            foreach (FileInfo fi in fileNames)
            {
                Console.WriteLine(blankSpace + blankSpaceWithRow + "* " + fi.Name);
            }
            string[] directories = Directory.GetDirectories(path);
            FileAttributes attr = File.GetAttributes(path);

            foreach (string dir in directories)
            {
                string folderName = Path.GetFileName( dir );
                Console.WriteLine(blankSpace + blankSpaceWithRow + "|____" + folderName);
                //Console.WriteLine(dir);
                displayPath(dir,row+2);
            }
            //detect whether its a directory or file
            //if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            //    Console.WriteLine();
            //else
            //    Console.WriteLine("Its a file");
            Object a = new Object();
            return a;
        }
        static void Main(string[] args)
        {





            string path = @"C:\MojFolder";
            Console.WriteLine(path);
            displayPath(path,0);

            var reader = new StreamReader(File.OpenRead(@"C:\MojFolder\dochody.txt"));
            List<double> listA = new List<double>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                double converted = Convert.ToDouble(line);
                listA.Add(converted);
            }
            double sum = 0;
            foreach (double item in listA)
            {
                sum = sum+item;
                Console.WriteLine("dochod za miesiac " + item);
            }

            Console.WriteLine("suma "+sum);


            ////Directory.GetDirectories(path);

            //try
            //{
            //    if (!di.Exists(path))   // je�li folder nie istnieje
            //    {
            //        di.CreateDirectory(path);    // uworz folder
            //        di.CreateDirectory("Podkatalog pierwszy");
            //        di.CreateDirectory("Podkatalog drugi");
            //    }
            //    else
            //        Console.WriteLine("Data utworzenia katalogu {0}", di.GetCreationTime(path));

            //    Console.WriteLine("Nazwa katalogu {0}", di.GetDirectories(path));
            //    string[] podkatalogi = di.GetDirectories(path);
            //    foreach (string p in podkatalogi)
            //        Console.WriteLine("\t {0}", di.GetDirectories(p));  // wypisuje podkatalogi

            //    DirectoryInfo nadrzedny = di.GetParent(path);
            //    if (nadrzedny.Exists)
            //        Console.WriteLine("Katalog nadrz�dny {0}", nadrzedny.FullName);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadKey();
        }
    }
}
