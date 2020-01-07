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
    /// Interaktionslogik für uebersichtBestellungen.xaml
    /// </summary>
    public partial class uebersichtBestellungen : Page
    {
        MainWindow mainWindow;
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        List<Wareneingang> wareneingangsListe;
        List<Warenausgang> warenausgangsListe;
        public uebersichtBestellungen(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Wareneingang
            int WEID=-1;
            
            if(dggoodsreceipt.SelectedIndex>=0)
            {
                for (int i = 0; i <= dggoodsreceipt.SelectedIndex; i++)
                {
                    WEID = wareneingangsListe[i].WareneingangID;
                }
            }
            if(WEID!=-1)
            {
                try
                {
                    string File = System.IO.File.ReadAllText($"Wareneingang{WEID}.html");
                    Drucken drucken = new Drucken(File);
                    drucken.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Fehler",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                
            }
            
        }

        private void DataGridRow_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            //Warenausgang
            int WAID = -1;
            if(dggoodsissue.SelectedIndex>=0)
            {
                for(int i =0; i<=dggoodsissue.SelectedIndex;i++)
                {
                    WAID = warenausgangsListe[i].WarenausgangID;
                }
            }
            if(WAID!=-1)
            {
                try
                {
                    string File = System.IO.File.ReadAllText($"Warenausgang{WAID}.html");
                    Drucken drucken = new Drucken(File);
                    drucken.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ctx = new LagerverwaltungContext();
            wareneingangsListe = ctx.Wareneingang.ToList();
            warenausgangsListe = ctx.Warenausgang.ToList();
            dggoodsissue.DataContext = warenausgangsListe.OrderBy(x=>x.WarenausgangID);
            dggoodsreceipt.DataContext = wareneingangsListe.OrderBy(x=>x.WareneingangID);
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Tohome();
        }
    }
}
