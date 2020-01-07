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
    /// Interaktionslogik für deleteProducts.xaml
    /// </summary>
    public partial class deleteProducts : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Produkte> ProduktListe;
        ProduktKlasse produktKlasse;
        
        MainWindow mainWindow;
        public deleteProducts(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        //Funktion zum Laden aus der Datenbank
        public void Loadfromdb()
        {
            ctx = new LagerverwaltungContext();

            ProduktListe = ctx.Produkte.ToList();
            ParentGrid.DataContext = ProduktListe;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade aus Datenbank
            Loadfromdb();
        }

        private void deletefromdb(int ProduktNummer)
        {
            //weise zu löschendes Produkt zu
            Produkte delProdukt = ctx.Produkte.Where(x => x.ProduktNummer.Equals(ProduktNummer)).FirstOrDefault();
            //Lösche Produkt wenn es gefunden wurde
            if(delProdukt!=null)
            {
                //Alle Warenbewegungen und das Produkt löschen
                string delProductName = delProdukt.ProduktName;
                List<Wareneingang> delWEs = ctx.Wareneingang.Where(x => x.Waren.Produkte.ProduktNummer.Equals(delProdukt.ProduktNummer)).ToList();
                List<Warenausgang> delWAs = ctx.Warenausgang.Where(x => x.Waren.Produkte.ProduktNummer.Equals(delProdukt.ProduktNummer)).ToList();

                //alle Warenbewegungen löschen, die mit dem Produkt angesprochen wurden!
                foreach (Wareneingang wedel in delWEs)
                {
                    if(wedel!=null)
                    {
                        ctx.Wareneingang.Remove(wedel);
                        ctx.SaveChanges();
                    }
                }
                foreach(Warenausgang wadel in delWAs)
                {
                    if(wadel!=null)
                    {
                        ctx.Warenausgang.Remove(wadel);
                        ctx.SaveChanges();
                    }
                }
                
                ctx.Produkte.Remove(delProdukt);
                //Meldung für den Benutzer
                MessageBox.Show(delProductName + " wurde gelöscht");
                ctx.SaveChanges();
            }
        }

        private void Btndeleteproductsback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Btndeleteproductsdelete_Click(object sender, RoutedEventArgs e)
        {
            if(dgdeleteProductslist.SelectedItem!=null)
            { 
                //Produktnummer ermitteln
                int ProduktNummer = -1;
                for (int i = 0; i <= dgdeleteProductslist.SelectedIndex; i++)
                {
                    ProduktNummer = ProduktListe[i].ProduktNummer;
                }
                //wenn Produktnummer erfolgreich gefunden, Löschfunktion aufrufen
                if (ProduktNummer != -1)
                {
                    deletefromdb(ProduktNummer);
                }
                else
                {
                    MessageBox.Show("Produkt nicht gefunden");
                }
                Loadfromdb();
            }
            else
            {
                MessageBox.Show("Bitte ein Produkt auswählen");
            }
        }

        private void TbxdeleteProductssearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //suchfunktion
            string suche=(tbxdeleteProductssearch.Text);
            if(suche!="")
            {
                //suchfunktion durchführen
                Suche(suche);
            }
            else
            {
                //alle Daten laden
                Loadfromdb();
                ProduktListe = ctx.Produkte.ToList();
            }
        }
        private void Suche(string suchstring)
        {
            //Filterlisten erstellen
            var finditemName = ProduktListe.Where(x => x.ProduktName.ToString().ToLower().Contains(suchstring.ToLower()));
            var finditemNummer = ProduktListe.Where(x => x.ProduktNummer.ToString().ToLower().StartsWith(suchstring.ToLower()));

            //Wenn Filterlisten Inhalte haben, zeige sie an
            if (finditemName.Any())
            {
                ProduktListe= finditemName.ToList();
                ParentGrid.DataContext = ProduktListe;
            }
            else if (finditemNummer.Any())
            {
                ProduktListe = finditemNummer.ToList();
                ParentGrid.DataContext = ProduktListe;
            }
            else//ansonsten lade daten neu aus der Datenbank
            {
                Loadfromdb();
            }
        }

        
    }
}
