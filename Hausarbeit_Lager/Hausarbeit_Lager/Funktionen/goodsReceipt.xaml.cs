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
    /// Interaktionslogik für goodsReceipt.xaml
    /// </summary>
    public partial class goodsReceipt : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Lieferer> LiefererListe;
        List<Waren> WarenListe;

        MainWindow mainWindow;
        public goodsReceipt(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade Daten aus Datenbank
            Loadfromdb();
        }


        private void Loadfromdb()
        {
            //neuer Context erstellen und Liste neu zuweisen
            ctx = new LagerverwaltungContext();
            ParentGrid.DataContext = ctx.Lieferer.ToList();
            
        }

        private void Btngoodsreceipt_Click(object sender, RoutedEventArgs e)
        {
            //Funktion um Wareneingang zu buchen
            Goodsreceipt();
        }

        private void Goodsreceipt()
        {
            //Listen neu zuweisen
            WarenListe = ctx.Waren.ToList();
            LiefererListe = ctx.Lieferer.ToList();

            //gehe zum selektiertem Gut
            string ProduktName = lbxgoodsreceiptgoods.SelectedItem.ToString();
            
            Produkte produkte = (Produkte)lbxgoodsreceiptgoods.SelectedItem;
            Waren waren = ctx.Waren.Where(x=>x.Produkte.ProduktNummer.Equals(produkte.ProduktNummer)).FirstOrDefault();
            //wenn es gefunden wurde führe Aktion aus
            if (waren!=null)
            {
                //fragen ob die Transaktion wirklich durchgeführt werden soll
                MessageBoxResult messageBox = MessageBox.Show($"Sie wollen in Ihr Lager {tbxgoodsreceiptdelivered.Text} Stück des Artikels {waren.Produkte.ProduktName} hinzufügen?", "Frage", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(messageBox.Equals(MessageBoxResult.Yes))
                {
                    //aktueller Bestand anpassen
                    waren.AktBestand = waren.AktBestand + Convert.ToInt32(tbxgoodsreceiptdelivered.Text);
                    ctx.SaveChanges();
                }
                else
                {
                    //Benutzer darauf hinweisen das die Transaktion nicht durchgeführt wurde
                    MessageBox.Show("Transaktion abgebrochen!", "Info",MessageBoxButton.OK,MessageBoxImage.Information);
                    return;
                }

                //Wareneingang Tabelle eintrag hinzufügen
                Wareneingang wareneingang = new Wareneingang();
                Lieferer lieferer = (Lieferer)lbxgoodsreceiptdeliverer.SelectedItem;
                wareneingang.WareneingangID = ctx.Wareneingang.Count() + 1;
                wareneingang.Artikel = waren.ArtikelNr;
                wareneingang.Lieferer = lieferer.LiefererNR;
                wareneingang.Bestellmenge = Convert.ToInt32(tbxgoodsreceiptdelivered.Text);
                //Daten in Tabelle hinzufügen
                ctx.Wareneingang.Add(wareneingang);
                ctx.SaveChanges();
                //Kontrollausgabe für den Benutzer
                MessageBox.Show($"Artikel: {waren.Produkte.ProduktName}\nMenge: {tbxgoodsreceiptdelivered.Text}\nLieferer: {lieferer.LiefererName}");
                //Template erstellen mit RazorEngine
                string htmlFile = System.IO.File.ReadAllText("wareneingangtemplate.cshtml");
                int weid = ctx.Wareneingang.Count();
                string result = Engine.Razor.RunCompile(htmlFile, $"WETemplate{weid}", null, wareneingang);
                int warenEingangAnz = ctx.Wareneingang.Count();
                System.IO.File.WriteAllText($"Wareneingang{warenEingangAnz}.html", result);
                tbxgoodsreceiptdelivered.Clear();

            }
            else
            {
                MessageBox.Show("Fehler");
            }

        }
        
        //Prüfe Datentypen
        private bool Check()
        {
            int MengeistZahl;
            if (tbxgoodsreceiptdelivered.Text != null)
            {
                //gibt nur true zurück wenn eine Ganzzahl eingegeben wurde
                if (Int32.TryParse(tbxgoodsreceiptdelivered.Text, out MengeistZahl) && lbxgoodsreceiptdeliverer.SelectedItem != null && lbxgoodsreceiptgoods.SelectedItem != null)
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

        private void Btngoodsreceiptback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            tbxgoodsreceiptdelivered.Clear();
            mainWindow.Tohome();
        }

        private void Lbxgoodsreceiptgoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Prüfe ob Datentyp richtig ist
            if (Check())
            {
                btngoodsreceipt.IsEnabled = true;
            }
            else
            {
                btngoodsreceipt.IsEnabled = false;
            }
        }

        private void Tbxgoodsreceiptdelivered_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfe ob Datentyp richtig ist
            if (Check())
            {
                btngoodsreceipt.IsEnabled = true;
            }
            else
            {
                btngoodsreceipt.IsEnabled = false;
            }
        }
    }
}
