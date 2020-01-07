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
    /// Interaktionslogik für Hauptmenue.xaml
    /// </summary>
    public partial class Hauptmenue : Page
    {
        MainWindow mainWindow;
        public Hauptmenue(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }
        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            //zum Login gehen
            mainWindow.Tologinpage();
        }

        private void Btnend_Click(object sender, RoutedEventArgs e)
        {
            //Programm beenden
            Application.Current.Shutdown();
        }

        private void Btnreg_Click(object sender, RoutedEventArgs e)
        {
            //zur registrierung
            mainWindow.Toregistrationpage();
        }
    }
}
