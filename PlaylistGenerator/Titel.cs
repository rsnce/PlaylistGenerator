using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenerator
{
    public class Titel
    {
        public string Dateipfad { get; set; }
        
        //public double Laenge { get; set; }

        public Titel(string dateipfad)
        {
            Dateipfad = dateipfad;
        }
        public override string ToString()
        {
            List<string> temp = Dateipfad.Split('\\').ToList();
            return temp.Last().Substring(0, temp.Last().Length - 4);
        }
    }
}
