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
    /// Interaktionslogik für CustomizeThisProduct.xaml
    /// </summary>
    public partial class CustomizeThisProduct : Page
    {
        MainWindow mainWindow;
        ListCollectionView ListCollectionView;
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        public CustomizeThisProduct(MainWindow wnd, int POS)
        {
            InitializeComponent();
            mainWindow = wnd;

            Load(POS);
        }

        private void Load(int POS)
        {
            //ListCollectionView zur übergebenen Postition 
            List<Produkte> PListe = ctx.Produkte.ToList();
            ListCollectionView = new ListCollectionView(PListe);
            ListCollectionView.MoveCurrentToPosition(POS);
            ParentGrid.DataContext = ListCollectionView;
        }

        private void BtncustomizeProductback_Click(object sender, RoutedEventArgs e)
        {
            //zurück gehen
            mainWindow.ToCustomizeProducts();
        }

        private void BtncustomizeProduct_Click(object sender, RoutedEventArgs e)
        {
            //Änderungen speichern
            ctx.SaveChanges();
            //Rückmeldung an den Benutzer
            MessageBox.Show("Produkt erfolgreich bearbeitet!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TbxcustomizeProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prüfe ob alle Pflichtfelder ausgefüllt sind
            TextBox[] PflichtFelder = { tbxcustomizeProductName };
            if(StandardKlasse.Pruefe(PflichtFelder))
            {
                btncustomizeProduct.IsEnabled = true;
            }
            else
            {
                btncustomizeProduct.IsEnabled = false;
            }
        }
    }
}
