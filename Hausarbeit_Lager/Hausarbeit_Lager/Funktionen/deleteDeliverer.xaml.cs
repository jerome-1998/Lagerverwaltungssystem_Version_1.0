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
    /// Interaktionslogik für deleteDeliverer.xaml
    /// </summary>
    public partial class deleteDeliverer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Lieferer> LieferListe;
        LiefererKlasse liefererKlasse=new LiefererKlasse();
        MainWindow mainWindow;
        public deleteDeliverer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade Daten aus Datenbank
            liefererKlasse.LoadDelivererfromDB(ParentGrid, ctx);
            LieferListe = liefererKlasse.lList;
        }

        private void Tbxdeletedeliverersearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Suchfunktion
            string suche = tbxdeletedeliverersearch.Text;
            if (suche != "")
            {
                liefererKlasse.SucheLieferer(suche,ref LieferListe,ParentGrid);
            }
            else
            {
                liefererKlasse.LoadDelivererfromDB(ParentGrid,ctx);
                LieferListe = liefererKlasse.lList;
            }
        }

        private void Btndeletedelivererdelete_Click(object sender, RoutedEventArgs e)
        {
            //Prüfe ob Item ausgewählt ist
            if (dgdeletedeliverlist.SelectedItem != null)
            {
                int LNR = -1;
                //ermittle Lieferernummer anhand des Indexes
                Lieferer lieferer = (Lieferer)dgdeletedeliverlist.SelectedItem;
                LNR = lieferer.LiefererNR;
                //rufe Funktion zum löschen des Lieferers auf, wenn Lieferernummer gefunden wurde
                if (LNR!=-1)
                {
                    deletedelivererfromdb(LNR);
                }
                //Aktualisiere DataGrid
                liefererKlasse.LoadDelivererfromDB(ParentGrid, ctx);
                LieferListe = liefererKlasse.lList;
            }
            else
            {
                MessageBox.Show("Bitte einen Kunde auswählen, der gelöscht werden soll");
            }
        }

        private void Btndeletedelivererback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void deletedelivererfromdb(int id)
        {
            //Weise Lieferer und Ansprechpartner zu
            Lieferer delLieferer = ctx.Lieferer.Where(x => x.LiefererNR.Equals(id)).FirstOrDefault();
            int ANummer = delLieferer.LAnsprechpartner.AnprechPartnerNummer;
            LAnsprechpartner delAnsprechpartner = ctx.LAnsprechpartner.Where(x => x.AnprechPartnerNummer.Equals(ANummer)).FirstOrDefault();
            if(delLieferer!=null)
            {
                string delLiefererName = delLieferer.LiefererName;
                //Alle Wareneingänge löschen die vom Lieferer angesprochen werden
                List<Wareneingang> delWEs = ctx.Wareneingang.Where(x => x.Lieferer1.LiefererNR.Equals(delLieferer.LiefererNR)).ToList();
                foreach(Wareneingang wedel in delWEs)
                {
                    if(wedel!=null)
                    {
                        ctx.Wareneingang.Remove(wedel);
                        ctx.SaveChanges();
                    }
                }
                //Lösche Ansprechpartner und Lieferer aus Datenbank
                ctx.LAnsprechpartner.Remove(delAnsprechpartner);
                ctx.Lieferer.Remove(delLieferer);
                //speichere Änderungen
                ctx.SaveChanges();
                MessageBox.Show(delLiefererName + " wurde gelöscht!");
            }
        }

        
    }
}
