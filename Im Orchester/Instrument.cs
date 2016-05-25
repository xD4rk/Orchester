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
        public void Spielen_Eventhandler(object sender, EventArgs o)
        {
          // ((OrchesterEventArgs)o).lbox.Items.Add();
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
        private Dirigent dg;
        public Violine(Dirigent d)
        {
            dg = d;
            d.DirigentSpielen += spielen;
        }
        public void  spielen(object sender, EventArgs o)
        {

            note_spielen(dg.Notenliste[dg.actualChar]);
        }
        public void note_spielen(Note n)
        {
            
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
