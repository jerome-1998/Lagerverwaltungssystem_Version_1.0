using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Hausarbeit_Lager.Funktionen;

namespace Hausarbeit_Lager.Funktionen
{
    public class KundenKlasse
    {
        //Liste und Datenbankcontext erstellen
        public List<Kunde> kListe;
        public LagerverwaltungContext ctx = new LagerverwaltungContext();

        //Methode um Kundendaten aus der Datenbank zu laden
        internal void LoadCustomerfromDB(Grid grid, LagerverwaltungContext ctx)
        {
            ctx = new LagerverwaltungContext();
            kListe= ctx.Kunde.ToList();
            grid.DataContext = kListe.OrderBy(x=>x.KundenNr);
        }
        
        internal bool KundeHinzufuegen(int KNummer, string KName, int KANummer,string KPLZ, string KAddresse, string KOrt, string KTelefon, string KEmail, string KWebsite, string AAnrede, string AVorname, string ANachname, string AHandynummer, string AEmail, string ATel, LagerverwaltungContext ctx)
        {
            //Context herstellen
            ctx=new LagerverwaltungContext();

            //lege Kunde und Anprechpartner an
            Kunde newCustomer = new Kunde();
            KAnsprechpartner newContactperson = new KAnsprechpartner();
            

            //Pflichtfelder werden ausgefüllt
            newCustomer.KundenNr = KNummer;
            newCustomer.KundenName = KName;
            newCustomer.Ansprechpartner = KANummer;
            newContactperson.AnsprechPartnerNummer = KANummer;

            //prüfe ob Inhalt vorhanden oder Datensätze null sind
            if (KPLZ.Any())
            {
                newCustomer.PLZ = KPLZ;
            }
            else
            {
                newCustomer.PLZ = null;
            }

            if (KAddresse.Any())
            {
                newCustomer.Adresse = KAddresse;
            }
            else
            {
                newCustomer.Adresse = null;
            }
            if (KOrt.Any())
            {
                newCustomer.Ort = KOrt;
            }
            else
            {
                newCustomer.Ort = null;
            }
            if (KTelefon.Any())
            {
                newCustomer.Telefonnummer = KTelefon;
            }
            else
            {
                newCustomer.Telefonnummer = null;
            }
            if (KEmail.Any())
            {
                newCustomer.EmailaddresseBetrieb = KEmail;
            }
            else
            {
                newCustomer.EmailaddresseBetrieb = null;
            }
            if (KWebsite.Any())
            {
                newCustomer.Website = KWebsite;
            }
            else
            {
                newCustomer.Website = null;
            }
            if (AAnrede.Any())
            {
                newContactperson.AnspAnrede = AAnrede;
            }
            else
            {
                newContactperson.AnspAnrede = null;
            }
            if (AVorname.Any())
            {
                newContactperson.AnspVorname = AVorname;
            }
            else
            {
                newContactperson.AnspVorname = null;
            }
            if (ANachname.Any())
            {
                newContactperson.AnspNachname = ANachname;
            }
            else
            {
                newContactperson.AnspNachname = null;
            }
            if (AHandynummer.Any())
            {
                newContactperson.AnpsHandyNummer = AHandynummer;
            }
            else
            {
                newContactperson.AnpsHandyNummer = null;
            }
            if (AEmail.Any())
            {
                newContactperson.AnspEmail = AEmail;
            }
            else
            {
                newContactperson.AnspEmail = null;
            }
            if (ATel.Any())
            {
                newContactperson.AnspTelefonnummer = ATel;
            }
            else
            {
                newContactperson.AnspTelefonnummer = null;
            }
            //Prüfe ob Kunde schon vorhanden ist
            if (ctx.Kunde.Where(x => x.KundenNr.Equals(KNummer)).FirstOrDefault() == null &&
                ctx.Kunde.Where(x => x.KundenName.Equals(KName)).FirstOrDefault() == null &&
                ctx.Kunde.Where(x => x.KAnsprechpartner.AnsprechPartnerNummer.Equals(KANummer)).FirstOrDefault() == null)
            {
                //füge alle eingegebenen daten in die fatenbank und speichere die änderungen
                ctx.Kunde.Add(newCustomer);
                ctx.KAnsprechpartner.Add(newContactperson);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                //Benutzerausgabe, die dem User sagt das der Kunde schon vorhanden ist
                if (ctx.Kunde.Where(x => x.KundenNr.Equals(KNummer)).FirstOrDefault()!=null)
                {
                    MessageBox.Show("Kundennummer ist bereits vorhanden!", "Fehler",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                else if(ctx.Kunde.Where(x => x.KundenName.Equals(KName)).FirstOrDefault()!=null)
                {
                    MessageBox.Show("Kundenname ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("AnsprechpartnerID ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                //gib False zurück               
                return false;
            }
        }

        internal void SucheKunde(string SucheNach,ref List<Kunde> KundenListe, Grid ParentGrid)
        {
            //Filterlisten erstellen, die prüfen ob Inhalt in Liste vorkommt
            var FilterListKN = KundenListe.Where(x=>x.KundenName.ToString().ToLower().Contains(SucheNach.ToLower()));
            var FilterListKNR= KundenListe.Where(x => x.KundenNr.ToString().ToLower().Contains(SucheNach.ToLower()));

            //Prüfen ob die Filterlisten null sind oder einen Inhalt besitzen
            if (FilterListKN.Any())
            {
                //DatenContext aus Filterliste zuweisen
                KundenListe = FilterListKN.ToList();
                ParentGrid.DataContext = KundenListe;
            }
            else if (FilterListKNR.Any())
            {
                KundenListe = FilterListKNR.ToList();
                ParentGrid.DataContext = KundenListe;
            }
            else
            {
                //Liste neu laden
                LoadCustomerfromDB(ParentGrid, ctx);
            }

        }
    }
}
