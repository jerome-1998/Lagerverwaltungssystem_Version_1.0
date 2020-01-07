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
using System.Windows.Shapes;
using System.Printing;
using System.Drawing.Printing;

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für Drucken.xaml
    /// </summary>
    public partial class Drucken : Window
    {
        //Initialisiere einen WinForms-Webbrowser
        System.Windows.Forms.WebBrowser printwb = new System.Windows.Forms.WebBrowser();
        //standartwert festlegen
        string File="";
        public Drucken(string htmlFile)
        {
            InitializeComponent();
            
            //Standartwert überschreiben            
            File = htmlFile;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Webbrowser befüllen
            myWebBrowser.NavigateToString(File);
        }

        private void BtnDruckDrucken_Click(object sender, RoutedEventArgs e)
        {            

            //wenn Drucken erfolgreich abgeschlossen wird gib eine positive Rückmeldung
            if (Print(File))
            {
                //Positive Rückmeldung
                MessageBox.Show("Dokument wird gedruckt!");
            }
            //ansonsten gib eine Fehlermeldung aus
            else
            {
                //Fehlermeldung
                MessageBox.Show("Ein unbekannter Fehler ist aufgetreten");
            }
            
            //Fenster unsichtbar machen, schliesen würde es für die restliche Laufzeit nicht wieder aufrufbar machen
            this.Hide();
        }

        private bool Print(string File)
        {
            //Anzahl der Kopien
            short cop = 1;
            //Papiertyp
            string PaperName = "A4";
            //Bei erfolg wird true zurückgegeben, bei einem Fehler false
            try
            {
                //Druckereinstellungen Festlegen
                PrinterSettings printSet = new PrinterSettings
                {
                    //Anzahl der Kopien Festlegen
                    Copies = cop,
                };
                //Seiteneinstellungen festlegen
                PageSettings pageSettings = new PageSettings(printSet)
                {
                    //Margins sind bei 0
                    Margins = new Margins(0, 0, 0, 0),
                };
                //laufe alle PaperSizes durch
                foreach(PaperSize ps in printSet.PaperSizes)
                {
                    //wenn der Name 'A4' ist wird die PaperSize festgelegt
                    if(ps.PaperName==PaperName)
                    {
                        pageSettings.PaperSize = ps;
                        break;
                    }
                }
                //Drucke wenn Webbrowser das Dokument geladen hat
                printwb.DocumentCompleted += Print_Doc;
                //Webbrowser befüllen
                printwb.DocumentText = File;
                //gib true zurück
                return true;
            }
            catch
            {
                //gib false zurück
                return false;
            }
        }

        private void Print_Doc(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            //Druckdialog
            printwb.ShowPrintDialog();
        }

        private void BtnDruckAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            //Fenster schliesen (unsichtbar machen) im Falle des Abbruchs 
            this.Hide();
        }
    }
}
