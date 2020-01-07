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

namespace Hausarbeit_Lager.Funktionen
{
    /// <summary>
    /// Interaktionslogik für totalinventory.xaml
    /// </summary>
    public partial class totalinventory : Page
    {
        LagerverwaltungContext ctx= new LagerverwaltungContext();
        List<Waren> WarenListe;

        ProduktKlasse produktKlasse = new ProduktKlasse();
        MainWindow mainWindow;
        public totalinventory(MainWindow wnd)
        {
            InitializeComponent();
            
            mainWindow = wnd;
        }

        private void btntotalinvgoback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Datenbankdaten laden
            produktKlasse.LoadFromDB(parentGrid, ctx);
            WarenListe = produktKlasse.wList;
        }

        private void Tbxtotalinventorysearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Suchtext einspeichern
            string suche = tbxtotalinventorysearch.Text.ToString().ToLower();
            if(suche!="")
            {
                //suchfunktion durchführen
                produktKlasse.ProduktSuche(suche, WarenListe, parentGrid);
            }
            else
            {
                //alle Daten laden
                produktKlasse.LoadFromDB(parentGrid,ctx);
                WarenListe = produktKlasse.wList;
            }
            
        }

        
    }
}
