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

using System.Security.Cryptography;

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        internal MainWindow mainWindow;
        //Standartwertwert für Iterationen festlegen
        public static int numberOfIterations = 10000;
        LagerverwaltungContext ctx;

        //Bilde eine BenutzerListe
        List<BenutzerProfil> NutzerListe; 
        public Loginpage(MainWindow wnd)
        {
            InitializeComponent();

            ctx = new LagerverwaltungContext();
            mainWindow = wnd;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //weise Benutzerliste zu
            NutzerListe = ctx.BenutzerProfil.ToList();
        }

        private string getHashfromDB(string username)
        {
            //Benutzerprofil suchen in Datenbank
            BenutzerProfil bp = NutzerListe.Where(x=>x.NutzerName.ToLower().Equals(username.ToLower())).FirstOrDefault();
            if(bp!=null)
            {
                //wenn ein Benutzerprofil mit dem übergebenen Namen gefunden wurde gib den hashwert des Passwortes zurück
                return bp.hash;
            }
            else
            {
                //ansonsten gib einen Null wert zurück
                return null;
            }
        }

        private string getSaltfromDB(string username)
        {
            //Benutzerprofil in Datenbank suchen
            BenutzerProfil bp = NutzerListe.Where(x => x.NutzerName.ToLower().Equals(username.ToLower())).FirstOrDefault();
            if (bp != null)
            {
                //wenn Benutzerprofil gefunden wurde gib den Saltwert des Passwortes zurück
                return bp.salt;
            }
            else
            {
                //ansonsten gib einen Null wert zurück
                return null;
            }
        }

        //Loginfunktion
        private bool Login(string an, string pw)
        {
            //Speichere Salt wert von dem Übergebenen Benutzer
            string salt = getSaltfromDB(an);


            if(salt!=null)
            {
                //bilde ein ByteArray vom Salt string
                byte[] saltBytes = Convert.FromBase64String(salt);

                //Hashwert für das eingegebene Passwort festlegen
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(pw, saltBytes);
                //Weise dieselbe Iterationennummer wie beim Generieren des Passwortes zu
                rfc2898DeriveBytes.IterationCount = numberOfIterations;
                //Bilde ByteArray für für den HashWert
                byte[] enteredHash = rfc2898DeriveBytes.GetBytes(20);
                //Wandle Hash-ByteArray in string um
                string hashstring = Convert.ToBase64String(enteredHash);
                //Bilde zu erwarteten String
                string expectedHash = getHashfromDB(an);
                //prüfe ob der zu erwartende String gleich dem übergebenen ist
                bool istrue = expectedHash.Equals(hashstring);
                //gib zurück ob der Wert true oder false ist
                return istrue;
            }
            else
            {
                //wenn kein Benutzer gefunden wurde gib false zurück
                return false;
            }
            
        }

        private void btnloginlogin_Click(object sender, RoutedEventArgs e)
        {
            //Speicher die übergebenen Werte zwischen
            string nickname = tbxloginnickname.Text;
            string password = pwbxloginpassword.Password;

            //prüfe ob Login true zurück gibt
            if(Login(nickname,password))
            {
                //wenn ja gehe zur HomeSeite
                mainWindow.Tohome(nickname);
            }
            else
            {
                //ansonsten gib dem Benutzer eine Fehlermeldung zurück
                MessageBox.Show("Anmeldedaten falsch, bitte versuchen Sie es erneut");
            }
            
            
        }

        private void BtnLogincancel_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tomainmenue();
        }

        
    }
}
