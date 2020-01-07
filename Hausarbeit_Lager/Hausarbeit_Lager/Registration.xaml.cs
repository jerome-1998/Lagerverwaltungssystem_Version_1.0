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

using System.Diagnostics;
using System.Security.Cryptography;

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        LagerverwaltungContext ctx;
        MainWindow mainWindow;
        //Standart Wert für Iterationen festlegen
        public static int numberOfIterations = 10000;
        //Klassenvariable für Anzahl der Benutzer
        public static int NutzerNR = 0;

        public Registration(MainWindow wnd)
        {
            InitializeComponent();

            ctx = new LagerverwaltungContext();
            //Anzahl der Benutzer wird zugewiesen
            NutzerNR = ctx.BenutzerProfil.Count();
            mainWindow = wnd;
        }

        private void btnregcancel_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tomainmenue();
        }

        private void btnregaccept_Click(object sender, RoutedEventArgs e)
        {
            //Suche Benutzerprofil in der Datenbank
            BenutzerProfil tprofil = ctx.BenutzerProfil.Where(x => x.NutzerName == tbxregnickname.Text).FirstOrDefault();
            //Prüfe ob alle Felder ausgefüllt sind
            if(tbxregnickname.Text != "" && pwbxregpassword.Password != "")
            {
                //Wenn Benutzer nicht in Datenbank vorhanden ist, führe aus
                if (tprofil == null && pwbxregpasswordtwo.Password == pwbxregpassword.Password)
                {
                    //Lege Benutzer an
                    NutzerAnlegen(tbxregnickname.Text, pwbxregpassword.Password);
                    tbxregnickname.Clear();
                    pwbxregpassword.Clear();
                    pwbxregpasswordtwo.Clear();
                    //Gehe zur LoginSeite
                    mainWindow.Tologinpage();
                }
                else
                {
                    //Gib Fehlermeldung aus
                    MessageBox.Show("Nutzer schon vorhanden oder Passwörter nicht identisch!", "Warnung", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt werden");
            }
            
        }

        private void NutzerAnlegen(string NutzerName, string Password)
        {
            //Salt und Hash Werte für Passwort erzeugen
            SaltAndHash sh = GenerateSaltAndHash(Password);
            //neues Benutzerprofil anlegen
            BenutzerProfil benutzer = new BenutzerProfil();
            //Lager mit 1 Suchen
            LagerSystem lager = ctx.LagerSystem.Where(x => x.SystemNr == 1).FirstOrDefault();
            //Werte für neuen Benutzer eintragen
            benutzer.NutzerName = NutzerName;
            benutzer.hash = sh.hash;
            benutzer.salt = sh.salt;
            benutzer.NutzerNr = NutzerNR + 1;
            //Benutzer LagersystemNr 1 zuordnen
            benutzer.LagerSystem.Add(lager);
            //Benutzer anlegen
            ctx.BenutzerProfil.Add(benutzer);
            //Eintrag speichern
            ctx.SaveChanges();
            MessageBox.Show("Registrierung erfolgreich!", "Info", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        public static SaltAndHash GenerateSaltAndHash(string password)
        {
            //Hash und Salt Werte erzeugen
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, 32);
            //Iterationsnummer zuweisen
            rfc2898DeriveBytes.IterationCount = numberOfIterations;
            //ByteArray für hash Werte erzeugen
            byte[] hash = rfc2898DeriveBytes.GetBytes(20);
            //ByteArray für salt werte erzeugen
            byte[] salt = rfc2898DeriveBytes.Salt;

            //hash und salt ByteArrays in Strings Convertieren
            string saltString = Convert.ToBase64String(salt);
            string hashString = Convert.ToBase64String(hash);

            //gib einen gemeinsamen wert zurück
            return new SaltAndHash(saltString, hashString);
        }

    }
}
