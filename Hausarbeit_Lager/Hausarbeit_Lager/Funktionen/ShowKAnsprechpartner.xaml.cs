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
using System.Windows.Shapes;

namespace Hausarbeit_Lager.Funktionen
{
    /// <summary>
    /// Interaktionslogik für ShowKAnsprechpartner.xaml
    /// </summary>
    public partial class ShowKAnsprechpartner : Window
    {
        //Datenbankcontext herstellen und einen Kunden erstellen
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        Kunde thisKunde;
        public ShowKAnsprechpartner(Kunde kunde)
        {
            InitializeComponent();
            //Kunde zuweisen
            thisKunde = kunde;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten laden
            ParentGrid.DataContext = thisKunde;
        }

        private void Btnkaback_Click(object sender, RoutedEventArgs e)
        {
            //Fenster schliesen
            this.Visibility = Visibility.Hidden;
        }
    }
}
