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
using RazorEngine;
using RazorEngine.Templating;

namespace Hausarbeit_Lager.Funktionen
{
    /// <summary>
    /// Interaktionslogik für goodsIssue.xaml
    /// </summary>
    public partial class goodsIssue : Page
    {
        

        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Waren> WarenListe;

        MainWindow mainWindow;
        public goodsIssue(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void Loadfromdb()
        {
            //neuen Context erstellen
            ctx = new LagerverwaltungContext();
            //Listen zuweisen
            ParentGrid.DataContext = ctx.Kunde.ToList();

            //standartselektierung vornehmen um mögliche Fehler abzufangen
            lbxgoodsissuecustomer.SelectedIndex = 0;
            lbxgoodsissuegoods.SelectedIndex = 0;
        }

        private void Btngoodsissueback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Btngoodsissue_Click(object sender, RoutedEventArgs e)
        {
            //Wähle Produkt anhand von Produknummer aus
            Produkte produkte = (Produkte)lbxgoodsissuegoods.SelectedItem;
            Waren waren = ctx.Waren.Where(x => x.Produkte.ProduktNummer.Equals(produkte.ProduktNummer)).FirstOrDefault();
            //Prüfe ob Produkt gefunden wurde
            if (waren != null)
            {
                //Prüfe ob Mindestbestand unterschritten wird
                int aktBestand = Convert.ToInt32(waren.AktBestand);
                int Menge;

                if (Int32.TryParse(tbxgoodsissueamount.Text, out Menge))
                {

                }
                else
                {
                    MessageBox.Show("Warenmenge darf keine Kommazahl sein oder Buchstaben enthalten!", "Warnung", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (waren.AktBestand >=  Menge)
                {
                    MessageBoxResult messageBoxResult = MessageBox.Show($"Sie aus ihrem Lager {tbxgoodsissueamount.Text} Stück des Artikels {waren.Produkte.ProduktName} entfernen?", "Frage", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (messageBoxResult.Equals(MessageBoxResult.Yes))
                    {

                        if (waren.Mindestbestand > (aktBestand = Convert.ToInt32(waren.AktBestand) - Menge))
                        {
                            //Frage ob Mindesbestand unterschritten werden soll!
                            MessageBoxResult messageBox = MessageBox.Show($"Mit dieser Transaktion wird der Mindesbestand " +
                                                                    $"des Produktes unterschritten, wollen Sie fortfahren?", "Warnung",
                                                                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                            if (messageBox == MessageBoxResult.Yes)
                            {
                                //Buche Vorgang
                                waren.AktBestand = waren.AktBestand - Menge;
                                ctx.SaveChanges();
                            }
                            else
                            {
                                //Breche Vorgang ab
                                MessageBox.Show("Transaktion abgebrochen!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            }
                        }
                        else
                        {
                            //Buche Vorgang
                            waren.AktBestand = waren.AktBestand - Menge;
                            ctx.SaveChanges();
                        }
                    }
                    else
                    {
                        //Benutzer darauf hinweisen das die Transaktion nicht durchgeführt wurde
                        MessageBox.Show("Transaktion abgebrochen!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Nicht genügend Artikel im Bestand!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }


                //Fülle Daten in Warenausgangstabelle ein
                Warenausgang warenausgang = new Warenausgang();
                Kunde kunde = (Kunde)lbxgoodsissuecustomer.SelectedItem;
                warenausgang.WarenausgangID = ctx.Warenausgang.Count() + 1;
                warenausgang.Artikel = waren.ArtikelNr;
                warenausgang.Kunde = kunde.KundenNr;
                warenausgang.Bestellmenge = Convert.ToInt32(tbxgoodsissueamount.Text);
                ctx.Warenausgang.Add(warenausgang);
                ctx.SaveChanges();
                //Kontrollausgabe für den Benutzer
                MessageBox.Show($"Artikel: {waren.Produkte.ProduktName}\nMenge: {tbxgoodsissueamount.Text}\nKunde: {kunde.KundenName}");
                //Template erstellen mit RazorEngine
                string htmlFile = System.IO.File.ReadAllText("warenausgangtemplate.cshtml");
                int waid = ctx.Warenausgang.Count();
                string result = Engine.Razor.RunCompile(htmlFile, $"WATemplate{waid}", null, warenausgang);
                int warenAusgangAnz = ctx.Warenausgang.Count();
                System.IO.File.WriteAllText($"Warenausgang{warenAusgangAnz}.html", result);
                
            }

            //Textbox leeren
            tbxgoodsissueamount.Clear();

            //Setze selektierte Items auf 0, damit keine Fehler entstehen können
            lbxgoodsissuecustomer.SelectedIndex = 0;
            lbxgoodsissuegoods.SelectedIndex = 0;
        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade Daten aus der Datenbank
            Loadfromdb();
        }

        private bool Check()
        {
            int MengeistZahl;
            if (tbxgoodsissueamount.Text != null)
            {
                //gibt nur true zurück wenn eine Ganzzahl eingegeben wurde
                if (Int32.TryParse(tbxgoodsissueamount.Text, out MengeistZahl) && lbxgoodsissuecustomer.SelectedItem != null && lbxgoodsissuegoods.SelectedItem != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }


        private void Lbxgoodsissuegoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Check())
            {
                btngoodsissue.IsEnabled = true;
            }
            else
            {
                btngoodsissue.IsEnabled = false;
            }
            
        }

        private void Tbxgoodsissueamount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Check())
            {
                btngoodsissue.IsEnabled = true;
            }
            else
            {
                btngoodsissue.IsEnabled = false;
            }
        }
    }
}
