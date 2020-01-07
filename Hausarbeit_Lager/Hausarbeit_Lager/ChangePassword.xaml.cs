using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaktionslogik für ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        MainWindow mainWindow;
        LagerverwaltungContext ctx = new LagerverwaltungContext();

        public static int numberOfIterations = 10000;
        string user;
        public ChangePassword(MainWindow wnd,string username)
        {
            InitializeComponent();

            mainWindow = wnd;
            user = username;
        }

        private void Pbxchangepwoldpw_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //wenn alle Felder ausgefüllt sind aktiviere Button
            if(pbxchangepwoldpw.Password!=""&&pbxchangepwnewpw.Password!=""&&pbxchangepwrepeatnewpw.Password!="")
            {
                btnchangepw.IsEnabled = true;
            }
            else
            {
                btnchangepw.IsEnabled = false;
            }
        }

        private void Btnchangepwback_Click(object sender, RoutedEventArgs e)
        {
            //gehe zurück
            mainWindow.Tohome();
        }

        private void Btnchangepw_Click(object sender, RoutedEventArgs e)
        {
            //Überprüfe eingegebenes altes Passwort mit Passwort in Datenbank
            if(CheckOldPW(user,pbxchangepwoldpw.Password))
            {
                //Prüfe auf Tippfehler im neuen Passwort
                if (pbxchangepwnewpw.Password == pbxchangepwrepeatnewpw.Password)
                {
                    //ändere Passwort
                    Changepassword(user, pbxchangepwnewpw.Password);
                    MessageBox.Show("Passwort geändert! \nDie änderung werden beim nächsten Neustart des Programmes aktiviert.","Info",MessageBoxButton.OK,MessageBoxImage.Information);
                    pbxchangepwnewpw.Clear();
                    pbxchangepwoldpw.Clear();
                    pbxchangepwrepeatnewpw.Clear();
                }
            }
            else
            {
                MessageBox.Show("Falsches Passwort!", "Warnung", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private bool CheckOldPW(string UserName, string OldPassword)
        {
            //Speichere Salt-wert von dem angemeldeten Benutzer
            string salt = getSaltfromDB(UserName);
            
            //bilde ein ByteArray vom Salt string
            byte[] saltBytes = Convert.FromBase64String(salt);

            //Hashwert für das Passwort festlegen
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(OldPassword, saltBytes);
            //Weise dieselbe Iterationennummer wie beim Generieren des Passwortes zu
            rfc2898DeriveBytes.IterationCount = numberOfIterations;
            //Bilde ByteArray für für den HashWert
            byte[] enteredHash = rfc2898DeriveBytes.GetBytes(20);
            //Wandle Hash-ByteArray in string um
            string hashstring = Convert.ToBase64String(enteredHash);
            //Bilde zu erwarteten String
            string expectedHash = getHashfromDB(UserName);
            //prüfe ob der zu erwartende String gleich dem übergebenen ist
            bool istrue = expectedHash.Equals(hashstring);
            //gib zurück ob der Wert true oder false ist
            return istrue;
        }

        private void Changepassword(string Username, string NewPassword)
        {
            //Greife auf angemeldeten Benutzer zu
            BenutzerProfil User = ctx.BenutzerProfil.Where(x => x.NutzerName.Equals(Username)).FirstOrDefault();
            //Generiere Salt und Hash Wert für übergebenes Passwort
            SaltAndHash sh = GenerateSaltAndHash(NewPassword);
            //Ändere Hash und Salt
            User.hash=sh.hash;
            User.salt=sh.salt;
            //speichere Änderungen
            ctx.SaveChanges();
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

        private string getHashfromDB(string username)
        {
            //Benutzerprofil suchen in Datenbank
            BenutzerProfil bp = ctx.BenutzerProfil.Where(x => x.NutzerName.ToLower().Equals(username.ToLower())).FirstOrDefault();
            //gib den hash-Wert zurück
            return bp.hash;
            
        }

        private string getSaltfromDB(string username)
        {
            //Benutzerprofil in Datenbank suchen
            BenutzerProfil bp = ctx.BenutzerProfil.Where(x => x.NutzerName.ToLower().Equals(username.ToLower())).FirstOrDefault();
            //gib den salt-wert zurück
            return bp.salt;
           
        }
    }
}
