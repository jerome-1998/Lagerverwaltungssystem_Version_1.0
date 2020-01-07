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
    /// Interaktionslogik für addDeliverer.xaml
    /// </summary>
    public partial class addDeliverer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        LiefererKlasse liefererKlasse = new LiefererKlasse();
        MainWindow mainWindow;

        public addDeliverer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void BtnaddDeliverer_Click(object sender, RoutedEventArgs e)
        {
            int LNummer;
            int ANummer;
            string LName = tbxaddDelivererDName.Text;

            //Prüfe auf richtige Datentypen
            if(Int32.TryParse(tbxaddDelivererDNummer.Text, out LNummer)&&Int32.TryParse(tbxaddDelivererANummer.Text, out ANummer))
            {
                addDeliverertoDB(LNummer, LName, ANummer);
            }
            else
            {
                MessageBox.Show("Lieferernummer und Ansprechpartnernummer dürfen keine Kommazahl sein");
            }
            
        }

        private void BtnaddDelivererback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();

        }

        private void addDeliverertoDB(int LNummer, string LName, int LANummer)
        {
            //speichere Textboxinhalte in strings
            string LPLZ = tbxaddDelivererDPLZ.Text;
            string LAddresse = tbxaddDelivererDAddresse.Text;
            string LOrt = tbxaddDelivererDOrt.Text;
            string LTelefon = tbxaddDelivererDTelefon.Text;
            string LEmail = tbxaddDelivererDEmail.Text;
            string LWebsite = tbxaddDelivererDWebsite.Text;

            string AAnrede = cobxaddDelivererAAnrede.SelectionBoxItem.ToString();
            string AVorname = tbxaddDelivererAVorname.Text;
            string ANachname = tbxaddDelivererANachname.Text;
            string AHandynummer = tbxaddDelivererAHandynummer.Text;
            string AEmail = tbxaddDelivererAEmail.Text;
            string ATel = tbxaddDelivererATelNummer.Text;

            
            
            
            //ALLE Textboxen werden in ein Array gespiechert
            TextBox[] textBoxes =
            {
            tbxaddDelivererDNummer,
            tbxaddDelivererANummer,
            tbxaddDelivererDName,

            tbxaddDelivererDPLZ,
            tbxaddDelivererDAddresse,
            tbxaddDelivererDOrt,
            tbxaddDelivererDNummer,
            tbxaddDelivererDEmail,
            tbxaddDelivererDTelefon,
            tbxaddDelivererDWebsite,

            tbxaddDelivererAVorname,
            tbxaddDelivererANachname,
            tbxaddDelivererAHandynummer,
            tbxaddDelivererAEmail,
            tbxaddDelivererATelNummer
            };
            //Wenn Lieferer angelegt wurde Werden alle Textboxen gecleart
            //Rufe Funktion zum Hinzufügen auf
            if (liefererKlasse.LiefererHinzufuegen(LNummer, LName, LANummer, LPLZ, LAddresse, LOrt, LTelefon, LEmail, LWebsite, AAnrede, AVorname, ANachname, AHandynummer, AEmail, ATel, ctx))
            { 
                StandardKlasse.ClearTBX(textBoxes);
                //Setze Combobox und Button zurück
                cobxaddDelivererAAnrede.SelectedIndex= 0;
                btnaddDeliverer.IsEnabled = false;
                MessageBox.Show("Lieferer erfolgreich hinzugefügt!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void TbxaddDelivererANummer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Überprüfe ob alle Pflichtfelder ausgefüllt sind
            TextBox[] textBoxes = { tbxaddDelivererANummer, tbxaddDelivererDName, tbxaddDelivererDNummer };
            if(StandardKlasse.Pruefe(textBoxes))
            {
                btnaddDeliverer.IsEnabled = true;
            }
            else
            {
                btnaddDeliverer.IsEnabled = false;
            }
        }
    }
}
