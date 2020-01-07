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
    /// Interaktionslogik für customizeDeliverer.xaml
    /// </summary>
    public partial class customizeDeliverer : Page
    {
        LagerverwaltungContext ctx=new LagerverwaltungContext();
        LiefererKlasse Liefklasse = new LiefererKlasse();

        MainWindow mainWindow;
        
        public customizeDeliverer(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
            
        }

        internal int LieferPos()
        {
            //gebe Position oder Index des ausgewählten Lieferers an der Liste aus
            return dgcustomizedeliverer.SelectedIndex;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //rufe Lieferer an der gewählten Position auf
            int LieferPosi = LieferPos();
            mainWindow.ToCustomizeThisDeliverer(LieferPosi);
        }

        private void Btncustomizedelivererback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //fülle Datagrid mit LiefererDaten
            Liefklasse.LoadDelivererfromDB(ParentGrid, ctx);
        }
    }
}
