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
    /// Interaktionslogik für ShowLAnsprechpartner.xaml
    /// </summary>
    public partial class ShowLAnsprechpartner : Window
    {
        //DatenbankContext und Lieferer erstellen
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        Lieferer thisLieferer;
        public ShowLAnsprechpartner(Lieferer lieferer)
        {
            InitializeComponent();
            //Lieferer zuweisen
            thisLieferer = lieferer;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten Laden
            ParentGrid.DataContext = thisLieferer;
        }

        private void Btnlaback_Click(object sender, RoutedEventArgs e)
        {
            //Fenster schliesen
            this.Visibility = Visibility.Hidden;
        }
    }
}
