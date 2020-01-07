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
using Hausarbeit_Lager.Funktionen;

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für leastwas.xaml
    /// </summary>
    public partial class leastwas : Page
    {

        MainWindow mainWindow;
        List<Waren> WarenListe;
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        ProduktKlasse produktKlasse=new ProduktKlasse();

        public leastwas(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        private void btnleastwasback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void btnleastwassave_Click(object sender, RoutedEventArgs e)
        {
            //wenn ein Item ausgeählt ist führe Methode aus
            if(dgleastwas.SelectedIndex>=0)
            {
                MindestbestandFestlegen();
            }
            else
            {
                //Benutzerausgabe, das kein Item ausgewählt ist
                MessageBox.Show("Bitte wählen Sie ein Produkt aus", "Warnung");
            }
            
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten aus der Datenbank laden und Liste befüllen
            produktKlasse.LoadFromDB(parentGrid,ctx);
            WarenListe = produktKlasse.wList;
        }

        private void Tbxleastwassearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Suchfunktion
            string searchstring = tbxleastwassearch.Text;
            if (searchstring != "")
            {
                produktKlasse.ProduktSuche(searchstring,WarenListe,parentGrid);
            }
            else
            {
                produktKlasse.LoadFromDB(parentGrid,ctx);
                WarenListe = produktKlasse.wList;
            }

        }

        //Methoden/Funktionen
        private void MindestbestandFestlegen()
        {
            //variable Festlegen
            int leastwasint;
            var leastwas = tbxleastwassetleastwas.Text;
            //Datentyp Prüfen
            if (Int32.TryParse(leastwas,out leastwasint))
            {
                //Position festlegen
                int i = dgleastwas.SelectedIndex;
                
                foreach(Waren w in WarenListe)
                {
                    //wenn Artikel gefunden wurde führe aus
                    if(w.ArtikelNr==((Waren)dgleastwas.Items[i]).ArtikelNr)
                    {
                        int ANR = w.ArtikelNr;
                        Waren waren = ctx.Waren.Where(x=>x.ArtikelNr.Equals(ANR)).FirstOrDefault();
                        //Mindestbestand zuweisen
                        waren.Mindestbestand = leastwasint;
                        ctx.SaveChanges();
                        //Daten neu aus Datenbank laden
                        //um Änderungen neu zu laden
                        produktKlasse.LoadFromDB(parentGrid, ctx);
                        WarenListe = produktKlasse.wList;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte nur ganze Zahlen eingeben", "Warnung", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
