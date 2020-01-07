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
    /// Interaktionslogik für showCustomer.xaml
    /// </summary>
    public partial class showCustomer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Kunde> KundenListe;
        KundenKlasse kundenKlasse=new KundenKlasse();
        MainWindow mainwindow;
        public showCustomer(MainWindow wnd)
        {
            InitializeComponent();
                        
            mainwindow = wnd;
        }

        private void Btnshowcustomerback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainwindow.Tohome();
        }

        private void Tbxshowcustomersearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Kundenliste zuweisen
            KundenListe = kundenKlasse.kListe;
            //Suchtext speichern
            string suche = tbxshowcustomersearch.Text;
            if(suche!="")
            {
                //Suche ausführen
                kundenKlasse.SucheKunde(suche,ref KundenListe, ParentGrid);
            }
            else
            {
                //Daten aus Datenbank neu laden
                kundenKlasse.LoadCustomerfromDB(ParentGrid, ctx);
                KundenListe = kundenKlasse.kListe;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten aus Datenbank laden
            kundenKlasse.LoadCustomerfromDB(ParentGrid,ctx);
            KundenListe = kundenKlasse.kListe;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //zeige Informationen über Ansprechpartner an
            Kunde kunde = (Kunde)dgshowcustomer.SelectedItem;
            ShowKAnsprechpartner kAnsprechpartner = new ShowKAnsprechpartner(kunde);
            //öffne Fenster mit den benötigten Informationen
            kAnsprechpartner.ShowDialog();
        }


    }
}
