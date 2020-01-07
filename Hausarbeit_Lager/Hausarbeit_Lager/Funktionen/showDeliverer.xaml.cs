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
    /// Interaktionslogik für showDeliverer.xaml
    /// </summary>
    public partial class showDeliverer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Lieferer> LiefererListe;
        LiefererKlasse liefererKlasse = new LiefererKlasse();
        MainWindow mainwindow;
        public showDeliverer(MainWindow wnd)
        {
            InitializeComponent();

            mainwindow = wnd;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten aus Datenbank laden
            liefererKlasse.LoadDelivererfromDB(ParentGrid,ctx);
            LiefererListe = liefererKlasse.lList;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //zeige Informationen über den Ansprechpartner an
            Lieferer lieferer = (Lieferer)dgshowdeliverer.SelectedItem;
            ShowLAnsprechpartner ansprechpartner = new ShowLAnsprechpartner(lieferer);
            ansprechpartner.ShowDialog();
            
        }


        private void Btnshowdelivererback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainwindow.Tohome();
        }

        private void Tbxshowdeliverersearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Liste zuweisen
            LiefererListe = liefererKlasse.lList;
            //Suchtext einspeichern
            string suche = tbxshowdeliverersearch.Text;
            if(suche!="")
            {
                //suche durchführen
                liefererKlasse.SucheLieferer(suche,ref LiefererListe,ParentGrid);
            }
            else
            {
                //Datenbankdaten neu laden
                liefererKlasse.LoadDelivererfromDB(ParentGrid,ctx);
                LiefererListe = liefererKlasse.lList;
            }
        }

    }
}
