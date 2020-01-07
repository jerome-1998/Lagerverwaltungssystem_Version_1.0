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
    /// Interaktionslogik für addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        KundenKlasse kundenKlasse=new KundenKlasse();
        MainWindow mainWindow;
        public addCustomer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void BtnaddCustomeradd_Click(object sender, RoutedEventArgs e)
        {
            int KNummer;
            int ANummer;
            string KName = tbxaddCustomerKName.Text;

            //Überprüfe auf richtige Datentypen
            if (Int32.TryParse(tbxaddCustomerKNummer.Text, out KNummer) && Int32.TryParse(tbxaddCustomerANummer.Text, out ANummer))
            {
                addCustomertoDB(KNummer, KName, ANummer);
            }
            else
            {
                MessageBox.Show("Kundennummer und Ansprechpartnernummer dürfen keine Kommazahl sein");
            }

        }
        private void BtnaddCustomerback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        //Füge KundenDaten in die Datenbank ein
        private void addCustomertoDB(int KNummer, string KName, int KANummer)
        {
            //speichere Textboxinhalte in strings
            string KPLZ = tbxaddCustomerKPLZ.Text;
            string KAddresse = tbxaddCustomerKAddresse.Text;
            string KOrt = tbxaddCustomerKOrt.Text;
            string KTelefon = tbxaddCustomerKTelefon.Text;
            string KEmail = tbxaddCustomerKEmail.Text;
            string KWebsite = tbxaddCustomerKWebsite.Text;

            string AAnrede = cobxaddCustomerAAnrede.SelectionBoxItem.ToString();
            string AVorname = tbxaddCustomerAVorname.Text;
            string ANachname = tbxaddCustomerANachname.Text;
            string AHandynummer = tbxaddCustomerAHandynummer.Text;
            string AEmail = tbxaddCustomerAEmail.Text;
            string ATel = tbxaddCustomerATelNummer.Text;

            
            
            //speichere ALLE Textboxen in ein array
            TextBox[] textBoxes = {
                tbxaddCustomerKNummer,
                tbxaddCustomerANummer,
                tbxaddCustomerKName,

                tbxaddCustomerKPLZ,
                tbxaddCustomerKAddresse,
                tbxaddCustomerKOrt,
                tbxaddCustomerKNummer,
                tbxaddCustomerKEmail,
                tbxaddCustomerKWebsite,
                tbxaddCustomerKTelefon,


                tbxaddCustomerAVorname,
                tbxaddCustomerANachname,
                tbxaddCustomerAHandynummer,
                tbxaddCustomerAEmail,
                tbxaddCustomerATelNummer
            };
            //Wenn der Kunde angelegt wurde werden alle Textboxinhalte gecleart
            //Rufe funktion zum hinzufügen auf
            if (kundenKlasse.KundeHinzufuegen(KNummer, KName, KANummer, KPLZ, KAddresse, KOrt, KTelefon, KEmail, KWebsite, AAnrede, AVorname, ANachname, AHandynummer, AEmail, ATel, ctx))
            {
                StandardKlasse.ClearTBX(textBoxes);
                //Zurücksetzen der Combobox und des Buttons
                cobxaddCustomerAAnrede.SelectedIndex = 0;
                btnaddCustomeradd.IsEnabled = false;
                MessageBox.Show("Kunde erfolgreich hinzugefügt!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }


        private void TbxaddCustomerANummer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Wenn Pflichtfelder ausgefüllt sind wird Button automatisch Freigeschaltet
            TextBox[] textBoxes = { tbxaddCustomerANummer, tbxaddCustomerKNummer, tbxaddCustomerKName };
            if(StandardKlasse.Pruefe(textBoxes))
            {
                btnaddCustomeradd.IsEnabled = true;
            }
            else
            {
                btnaddCustomeradd.IsEnabled = false;
            }
        }
    }
}
