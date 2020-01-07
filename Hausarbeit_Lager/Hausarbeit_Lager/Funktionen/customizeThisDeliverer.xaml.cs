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
    /// Interaktionslogik für customizeThisDeliverer.xaml
    /// </summary>
    public partial class customizeThisDeliverer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        ListCollectionView displaylist;
        List<Lieferer> LieferList;
        
        MainWindow mainWindow;
        
        public customizeThisDeliverer(MainWindow wnd, int POS)
        {
            InitializeComponent();
            
            
            mainWindow = wnd;
            Load(POS);
        }
        

        public void Load(int pos)
        {
            //ListCollectionView zur übergebenen Postition
            LieferList = ctx.Lieferer.ToList();
            displaylist = new ListCollectionView(ctx.Lieferer.ToList());
            displaylist.MoveCurrentToPosition(pos);
            ParentGrid.DataContext = displaylist;
            //Werte der ComboBox entsprechend anzeigen
            if(LieferList[pos].LAnsprechpartner.AnspAnrede=="Herr")
            {
                cobxcustomizeDelivererAAnrede.SelectedIndex = 0;
            }
            else if(LieferList[pos].LAnsprechpartner.AnspAnrede=="Frau")
            {
                cobxcustomizeDelivererAAnrede.SelectedIndex = 1;
            }
            else
            {
                cobxcustomizeDelivererAAnrede.SelectedIndex = 2;
            }
        }

        private void BtncustomizeDelivererback_Click(object sender, RoutedEventArgs e)
        {
            //gehe zurück
            mainWindow.ToCustomizeDeliverer();
        }
        
        private void BtncustomizeDeliverer_Click(object sender, RoutedEventArgs e)
        {
            //speichere alle Änderungen
            ctx.SaveChanges();
            //Rückmeldung an den Benutzer
            MessageBox.Show("Lieferer erfolgreich bearbeitet!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TbxcustomizeDelivererDNummer_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfe ob alle PFlichtfelder ausgefüllt sind
            TextBox[] PflichtFelder = { tbxcustomizeDelivererDName };
            if(StandardKlasse.Pruefe(PflichtFelder))
            {
                btncustomizeDeliverer.IsEnabled = true;
            }
            else
            {
                btncustomizeDeliverer.IsEnabled = false;
            }
        }
    }
}
