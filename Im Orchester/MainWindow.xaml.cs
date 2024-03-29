﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Im_Orchester
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dirigent d = new Dirigent();
        DispatcherTimer Timer = new DispatcherTimer();
        public string input = "d 1 | d 1 fis-a 1 | fis-a 1 P 1 d-fis 1 | d-fis 1 P 1";
        public MainWindow()
        {
            
            //d.Listbox_ausgabe = lbAusgabe;
            Violine vio = new Violine(d);
            Cello cello = new Cello();
            InitializeComponent();
            Timer.Tick += Timer_Tick;
            Timer.Start();
            Timer.Interval = new TimeSpan(0,0,0,1);
            d.Listbox_ausgabe = lbAusgabe;
            d.Partitur_einfügen(input);

        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            d.Spielen(this, new OrchesterEventArgs(lbAusgabe));
            //d.Spielen(this, new OrchesterEventArgs(lbAusgabe));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            d.Spielen(this, new OrchesterEventArgs(lbAusgabe));
            //d.Spielen(this,new OrchesterEventArgs(lbAusgabe));
            //d.Spielen(this, new EventArgs());
        }
    }
}
