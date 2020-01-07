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
    /// Interaktionslogik für customizeCustomer.xaml
    /// </summary>
    public partial class customizeCustomer : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        KundenKlasse kukl = new KundenKlasse();
        MainWindow mainWindow;
        public customizeCustomer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        internal int KundenPos()
        {
            //gebe Position/Index in der Liste aus
            return dgcustomizecustomer.SelectedIndex;
        }
        

        private void Btncustomizecustomerback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Funktion um datagrid mit Kundendaten zu füllen
            kukl.LoadCustomerfromDB(ParentGrid, ctx);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int Kundenposi = KundenPos();
            //rufe Kunde an der Position auf
            mainWindow.ToCustomizeThisCustomer(Kundenposi);
        }
    }
}
