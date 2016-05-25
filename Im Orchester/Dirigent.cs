using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Im_Orchester
{
    public class OrchesterEventArgs : EventArgs
    {
        public ListBox lbox;
        public OrchesterEventArgs(ListBox l)
        {
            lbox = l;
        }
        public OrchesterEventArgs()
        {
        }

    }
    public class Dirigent
    {
        public List<Note> Notenliste;
        public int position;
        public int actualChar=0;
        public string input = "";
        public event EventHandler DirigentSpielen;
        public ListBox Listbox_ausgabe { get; set; }
        public string Partitur { get; set; }

        
        public void Partitur_einfügen(string part)
        {
            input = part;
        }
        public void Spielen(object sender, OrchesterEventArgs o)
        {
            DirigentSpielen(this,o);
            nextChar();
        }
        public void nextChar()
            
        {
            Notenliste = new List<Note>();
            foreach (var item in input.Split('|'))
            {
                foreach (var buchstabe in item)
                {
                    
                    if(buchstabe.ToString() != " "){
                        if(buchstabe.ToString() == "f"){
                            Notenliste.Add(new Note("fis",(byte) 1,true));
                        }
                        else if (buchstabe.ToString() == "d")
                        {
                            Notenliste.Add(new Note("d", (byte)1, true));
                        }
                        else if (buchstabe.ToString() == "P")
                        {
                            Notenliste.Add(new Note("pause", (byte)0, false));
                        }
                        else if (buchstabe.ToString() == "a")
                        {
                            Notenliste.Add(new Note("a", (byte)0, false));
                        }
                    }
                  }
                Notenliste.Add(new Note("takt",(byte)0,false));
            }

            foreach (var item in Notenliste)
            {
                Listbox_ausgabe.Items.Add(item);
            }
        }

        //To do: event an die Instrumente mit einer gespielten Note, Timer...


    }
    
}
