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
    /// Interaktionslogik für deleteCustomer.xaml
    /// </summary>
    public partial class deleteCustomer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Kunde> KundenListe;
        KundenKlasse kukl = new KundenKlasse();

        MainWindow mainWindow;
        public deleteCustomer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void Btndeletecustomerdelete_Click(object sender, RoutedEventArgs e)
        {
            //Prüfe ob ein item ausgewählt ist
            if(dgdeletecustomerlist.SelectedItem!=null)
            { 
                int KNR=-1;
                //Ermittle Kundennummer
                Kunde kunde = (Kunde)dgdeletecustomerlist.SelectedItem;
                KNR = kunde.KundenNr;
                
                //Funktion um Kunde zu Löschen, wenn Kundennummer ermittelt wurde
                if (KNR!=-1)
                {
                    deletecustomerfromdb(KNR);
                }
                //Aktualisiere das Datagrid
                kukl.LoadCustomerfromDB(ParentGrid,ctx);
                KundenListe = kukl.kListe;
            }
            else
            {
                MessageBox.Show("Bitte einen Kunde auswählen, der gelöscht werden soll");
            }
        }

        private void Btndeletecustomerback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void deletecustomerfromdb(int id)
        {
            //weise Kunde zu
            Kunde delKunde= ctx.Kunde.Where(x => x.KundenNr.Equals(id)).FirstOrDefault();
            int ANummer = delKunde.KAnsprechpartner.AnsprechPartnerNummer;
            //weise Ansprechpartner zu
            KAnsprechpartner delAnsprechpartner = ctx.KAnsprechpartner.Where(x => x.AnsprechPartnerNummer.Equals(ANummer)).FirstOrDefault();
            if (delKunde != null)
            {
                //Alle Warenbewegungen löschen, die angesprochen werden mit dem Kunden
                List<Warenausgang> delWAs = ctx.Warenausgang.Where(x=>x.Kunde1.KundenNr.Equals(delKunde.KundenNr)).ToList();
                foreach (Warenausgang wadel in delWAs)
                {
                    if(wadel!=null)
                    {
                        ctx.Warenausgang.Remove(wadel);
                        ctx.SaveChanges();
                    }
                }
                //entferne Ansprechpartner und Kunde aus Datenbank
                ctx.KAnsprechpartner.Remove(delAnsprechpartner);
                ctx.Kunde.Remove(delKunde);
                //Speichere Änderung
                ctx.SaveChanges();
            }

        }

        private void Tbxdeletecustomer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Suchfunktion
            string suche = tbxdeletecustomer.Text;
            if(suche!="")
            {
                kukl.SucheKunde(suche,ref KundenListe,ParentGrid);
            }
            else
            {
                kukl.LoadCustomerfromDB(ParentGrid, ctx);
                KundenListe = kukl.kListe;
            }
            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade Daten aus Datenbank
            kukl.LoadCustomerfromDB(ParentGrid,ctx);
            KundenListe = kukl.kListe;
        }
    }
}
