using System;
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
        public string input = "d 1 | d 1 fis-a 1| fis-a 1 P 1 d-fis 1 | d-fis 1 P 1";
        public MainWindow()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
            Timer.Start();
            Timer.Interval = new TimeSpan(30000000);
            d.Listbox_ausgabe = lbAusgabe;

        }
        public void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            d.Partitur_einfügen(input);
            d.Spielen(this, new EventArgs());
        }
    }
}
