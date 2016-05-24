using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Im_Orchester
{
    public class Note
    {
        public string Hoehe { get; set; }
        public byte Dauer { get; set; }
        public bool Spielen { get; set; }


        public Note get_note(string s)
        {
            return new Note();
        }
    }
}
