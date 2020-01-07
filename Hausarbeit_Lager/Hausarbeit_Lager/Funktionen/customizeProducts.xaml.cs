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
    /// Interaktionslogik für customizeProducts.xaml
    /// </summary>
    public partial class customizeProducts : Page
    {
        MainWindow mainWindow;
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        
        public customizeProducts(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        internal int ProduktPos()
        {
            //gebe Produktposition zurück
            return dgcustomizedProducts.SelectedIndex;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //rufe Produkt an der gewählten Position auf
            int Produktposi = ProduktPos();
            mainWindow.ToCustomizeThisProduct(Produktposi);
        }

        private void Btncustomizedproductsback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Lade Produktdaten in Datagrid
            ctx = new LagerverwaltungContext();
            List<Produkte> ProduktListe = ctx.Produkte.ToList();
            ParentGrid.DataContext = ProduktListe;
        }
    }
}
