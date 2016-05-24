using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Im_Orchester
{
    public abstract class Instrument
    {
        public void Spielen_Eventhandler(object sender, EventArgs e){

        }

        public string Name { get; set; }
        public ListBox Listbox_ausgabe { get; set; }
        string note_spielen(Note n)
        {
            return "";
        }

    }
    public class Violine : Instrument
    {
        public void  spielen(object sender, EventArgs e){

        }
        public string note_spielen(Note n)
        {
            //To do
            return "";
        }
    }
    public class Cello : Instrument
    {
        public string note_spielen(Note n)
        {
            return "";
        }
    }
}
