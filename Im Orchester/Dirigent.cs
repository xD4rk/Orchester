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
            fillList();
        }
        public void Spielen(object sender, OrchesterEventArgs o)
        {
            if (Notenliste.Count > actualChar)
            {
                DirigentSpielen(this, o);
                actualChar++;
            }
        }

        public void goToNext()
        {
            
        }
        public void fillList()
            
        {
            var txt = "";
            Notenliste = new List<Note>();
            var typeafter = 0;
            foreach (var item in input.Split('|'))
            {
                foreach (var buchstabe in item)
               {
                    
                    if(buchstabe.ToString() != " "){

                        if (buchstabe.ToString() == "-")
                        {
                            if (Notenliste.Count > 0 && Notenliste[Notenliste.Count - 1].Hoehe != "fis")
                            {
                                Notenliste.Add(new Note(Notenliste[Notenliste.Count - 1].Hoehe + "-fis", (byte) 1, true));
                                Notenliste.RemoveAt(Notenliste.Count - 2);
                            }
                            else
                            {
                               

                            }
                        }
                        if(buchstabe.ToString() == "f"){
                            Notenliste.Add(new Note("fis",(byte) 1,true));
                        }
                        else if (buchstabe.ToString() == "d")
                        {
                            
                            if (Notenliste.Count > 0 && Notenliste[Notenliste.Count - 1].Hoehe == "fis")
                            {
                                Notenliste.RemoveAt(Notenliste.Count - 1);
                                Notenliste.Add(new Note("fis-d", (byte) 1, true));
                            }
                            else
                            {
                                Notenliste.Add(new Note("d", (byte)1, true));
                            }
                        }
                        else if (buchstabe.ToString() == "P")
                        {
                            Notenliste.Add(new Note("pause", (byte)0, false));
                        }
                        else if (buchstabe.ToString() == "a")
                        {
                            if(Notenliste.Count > 0 && Notenliste[Notenliste.Count - 1].Hoehe == "fis")
                            {
                                Notenliste.RemoveAt(Notenliste.Count - 1);
                                Notenliste.Add(new Note("fis-a", (byte)1, true));
                            }
                            else
                            {
                                Notenliste.Add(new Note("a", (byte)1, true));
                            }
                        }
                    }
                  }
                Notenliste.Add(new Note("takt",(byte)0,false));
            }

            
        }

        //To do: event an die Instrumente mit einer gespielten Note, Timer...


    }
    
}
