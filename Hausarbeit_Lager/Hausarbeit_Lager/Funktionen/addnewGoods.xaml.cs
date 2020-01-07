using Hausarbeit_Lager.Funktionen;
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

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für addnewGoods.xaml
    /// </summary>
    public partial class addnewGoods : Page
    {
        List<Waren> WarenListe;
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        ProduktKlasse PKlasse=new ProduktKlasse();

        
        

        MainWindow mainWindow;
        public addnewGoods(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
            btnaddnewgoods.IsEnabled = false;

        }

        private void Btnaddnewgoods_Click(object sender, RoutedEventArgs e)
        {
            //Überprüfe auf richtige Datentypeingabe
            float VAL;
            int ANR;
            int PNR;
            if(float.TryParse(tbxaddnewproductsvalue.Text,out VAL))
            {

            }
            else
            {
                VAL = 0;
            }
            if(Int32.TryParse(tbxaddnewproductsANR.Text,out ANR))
            {

            }
            else
            {
                //MessageBox.Show("Artikelnummer darf keine Kommazahl sein!", "Fehler", MessageBoxButton.OK,MessageBoxImage.Error);                
            }
            
            
            string PN = tbxaddnewproductsPN.Text;


            //Wenn alle Eingaben inordnung sind Wird das Produkt hinzugefügt
            if(checkdates())
            {
                //Funktion aufrufen um Produkt hinzuzufügen
                PKlasse.ProdukteHinzufuegen(ANR,ANR,VAL,PN,ctx);
                //gib Benutzer Rückmeldung
                MessageBox.Show("Produkt hinzugefügt!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                //Alle Textboxen werden in ein Arrayngespeichert
                TextBox[] textBoxes ={
                    tbxaddnewproductsANR,
                    tbxaddnewproductsPN,
                    tbxaddnewproductsvalue
                };
                //Textboxen werden gecleart!
                StandardKlasse.ClearTBX(textBoxes);                
            }
            
        }

        private void Btnaddnewgoodsback_Click(object sender, RoutedEventArgs e)
        {
            //Alle Textboxen werden in ein Arrayngespeichert
            TextBox[] textBoxes ={
                tbxaddnewproductsANR,
                tbxaddnewproductsPN,
                tbxaddnewproductsvalue
                };
            //Beim Verlassen der Seite werden Textboxen gecleart
            StandardKlasse.ClearTBX(textBoxes);
            mainWindow.Tohome();
        }

        private bool checkdates()
        {
            WarenListe = ctx.Waren.ToList();
            //Überprüfe auf Datentypen
            int ANR;
            int PNR;
            if (Int32.TryParse(tbxaddnewproductsANR.Text, out ANR))
            {

            }
            else
            {
                MessageBox.Show("Artikelnummer darf keine Kommazahl sein!","Fehler",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            
            string PN = tbxaddnewproductsPN.Text;
            if(PN==""||PN==null)
            {
                return false;
            }
            else
            {
                //Prüfe ob produkt schon vorhanden ist
                for (int i = 0; i < WarenListe.Count; i++)
                {
                    if (WarenListe[i].Produkte.ProduktNummer == ANR)
                    {
                        MessageBox.Show("Produktnummer ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                    else if (WarenListe[i].Produkte.ProduktName == PN)
                    {
                        MessageBox.Show("Produktname ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                    else if(WarenListe[i].ArtikelNr == ANR)
                    {
                        MessageBox.Show("Artikelnummer ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }

                return true;
            }
            
        }

        private void TbxaddnewproductsANR_TextChanged(object sender, TextChangedEventArgs e)
        {
            //prüfe ob alle pflichttextboxen ausgefüllt sind
            TextBox[] textBoxes = { tbxaddnewproductsPN, tbxaddnewproductsANR };
            if(StandardKlasse.Pruefe(textBoxes))
            {
                btnaddnewgoods.IsEnabled = true;
            }
            else
            {
                btnaddnewgoods.IsEnabled = false;
            }
        }
    }
}
