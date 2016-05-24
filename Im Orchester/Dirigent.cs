using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Im_Orchester
{
    class Dirigent
    {
        public event EventHandler DirigentSpielen;
        public ListBox Listbox_ausgabe { get; set; }
        public string Partitur { get; set; }

        //To do: event an die Instrumente mit einer gespielten Note, Timer...


    }
}
