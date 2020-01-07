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
    /// Interaktionslogik für customizeThisCustomer.xaml
    /// </summary>
    public partial class customizeThisCustomer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        ListCollectionView displaylist;
        List<Kunde> KundenListe;

        MainWindow mainWindow;
        public customizeThisCustomer(MainWindow wnd, int POS)
        {
            InitializeComponent();

            mainWindow = wnd;
            Load(POS);
        }

        private void Load(int pos)
        {
            //Lasse das ListCollectionView an die übergebene Position gehen
            KundenListe = ctx.Kunde.ToList();
            displaylist = new ListCollectionView(ctx.Kunde.ToList());
            displaylist.MoveCurrentToPosition(pos);
            ParentGrid.DataContext = displaylist;
            //Combobox Werte entsprechend anzeigen
            if (KundenListe[pos].KAnsprechpartner.AnspAnrede == "Herr")
            {
                cobxcustomizeCustomerAAnrede.SelectedIndex = 0;
            }
            else if (KundenListe[pos].KAnsprechpartner.AnspAnrede == "Frau")
            {
                cobxcustomizeCustomerAAnrede.SelectedIndex = 1;
            }
            else
            {
                cobxcustomizeCustomerAAnrede.SelectedIndex = 2;
            }
        }

        private void BtncustomizeCustomer_Click(object sender, RoutedEventArgs e)
        {
            //speichere Alle Änderungen
            ctx.SaveChanges();
            //Rückmeldung an den Benutzer
            MessageBox.Show("Kunde erfolgreich bearbeitet!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtncustomizeCustomerback_Click(object sender, RoutedEventArgs e)
        {
            //gehe zurück
            mainWindow.ToCustomizeCustomer();
        }

        private void TbxcustomizeCustomerCNummer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfe ob alle Pflichtfelder ausgefüllt sind
            TextBox[] PflichtFelder = { tbxcustomizeCustomerCName };
            if (StandardKlasse.Pruefe(PflichtFelder))
            {
                btncustomizeCustomer.IsEnabled = true;
            }
            else
            {
                btncustomizeCustomer.IsEnabled = false;
            }
        }
    }
}
