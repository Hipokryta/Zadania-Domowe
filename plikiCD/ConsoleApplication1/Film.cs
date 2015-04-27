using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    [XmlRoot("MovieColection")]
    public class Film 
    {
        [XmlArray("Movies"), XmlArrayItem("Movie")]
        public Film[] Movies { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Ranking { get; set; }
        public Film()
        {
        }

        public Film(int PersonId, string Name, string Title, int Year, int Ranking)
        {
            this.Id = PersonId;
            this.Name = Name;
            this.Title = Title;
            this.Year = Year;
            this.Ranking = Ranking;
        }
    }
}
