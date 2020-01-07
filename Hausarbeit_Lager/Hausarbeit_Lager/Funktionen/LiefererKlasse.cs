using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Hausarbeit_Lager.Funktionen
{
    class LiefererKlasse
    {
        //LiefererListe erstellen
        public List<Lieferer> lList;
        //DatenbankContext erstellen
        LagerverwaltungContext ctx = new LagerverwaltungContext();

        //Funktion um Lieferer aus Datenbank zu Laden
        internal void LoadDelivererfromDB(Grid grid, LagerverwaltungContext ctx)
        {
            ctx = new LagerverwaltungContext();
            lList= ctx.Lieferer.ToList();
            grid.DataContext = lList.OrderBy(x=>x.LiefererNR);
        }

        //Funktion um Lieferer Hinzuzufügen
        internal bool LiefererHinzufuegen(int LNummer, string LName, int LANummer, string LPLZ, string LAddresse, string LOrt, string LTelefon, string LEmail, string LWebsite, string AAnrede, string AVorname, string ANachname, string AHandynummer, string AEmail, string ATel, LagerverwaltungContext ctx)
        {
            //Datenbankcontext erstellen
            ctx = new LagerverwaltungContext();

            //lege Kunde und Anprechpartner an
            Lieferer newDeliverer= new Lieferer();
            LAnsprechpartner newContactperson = new LAnsprechpartner();

            
            //Pflichtfelder werden ausgefüllt
            newDeliverer.LiefererNR= LNummer;
            newDeliverer.LiefererName = LName;
            newDeliverer.Ansprechpartner = LANummer;
            newContactperson.AnprechPartnerNummer= LANummer;

            //prüfe ob inhalt vorhanden oder Daten null sind
            if (LPLZ.Any())
            {
                newDeliverer.PLZ = LPLZ;
            }
            else
            {
                newDeliverer.PLZ = null;
            }

            if (LAddresse.Any())
            {
                newDeliverer.Adresse = LAddresse;
            }
            else
            {
                newDeliverer.Adresse = null;
            }
            if (LOrt.Any())
            {
                newDeliverer.Ort = LOrt;
            }
            else
            {
                newDeliverer.Ort = null;
            }
            if (LTelefon.Any())
            {
                newDeliverer.Telefonnummer = LTelefon;
            }
            else
            {
                newDeliverer.Telefonnummer = null;
            }
            if (LEmail.Any())
            {
                newDeliverer.EmailaddresseBetrieb = LEmail;
            }
            else
            {
                newDeliverer.EmailaddresseBetrieb = null;
            }
            if (LWebsite.Any())
            {
                newDeliverer.Website = LWebsite;
            }
            else
            {
                newDeliverer.Website = null;
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

            //Prüfe ob Lieferer schon vorhanden ist
            if (ctx.Lieferer.Where(x => x.LiefererNR.Equals(LNummer)).FirstOrDefault()==null&& 
                ctx.Lieferer.Where(x => x.LiefererName.Equals(LName)).FirstOrDefault() == null&&
                ctx.Lieferer.Where(x => x.LAnsprechpartner.AnprechPartnerNummer.Equals(LANummer)).FirstOrDefault() == null)
            { 
                //füge alle eingegebenen daten in die fatenbank und speichere die änderungen
                ctx.Lieferer.Add(newDeliverer);
                ctx.LAnsprechpartner.Add(newContactperson);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                //Teile dem Benutzer mit, das der Lieferer schon vorhanden ist
                if (ctx.Lieferer.Where(x => x.LiefererNR.Equals(LNummer)).FirstOrDefault()!=null)
                {
                    MessageBox.Show("Lieferernummer ist bereits vorhanden!","Fehler",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                else if(ctx.Lieferer.Where(x => x.LiefererName.Equals(LName)).FirstOrDefault()!=null)
                {
                    MessageBox.Show("Lieferername ist bereits vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("AnsprechpartnerID ist schon vorhanden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                //Gib False zurück
                return false;
            }
        }

        //Suchfunktion Lieferer
        internal void SucheLieferer(string SucheNach,ref List<Lieferer> LiefererListe,Grid ParentGrid)
        {
            //Filterlisten erstellen
            var FilterListLN = LiefererListe.Where(x => x.LiefererName.ToString().ToLower().Contains(SucheNach.ToLower()));
            var FilterListLNR = LiefererListe.Where(x => x.LiefererNR.ToString().ToLower().Contains(SucheNach.ToLower()));
            
            //wenn ein oder mehr Inhalt/e vorhanden ist/sind zeige sie an 
            if (FilterListLN.Any())
            {
                LiefererListe = FilterListLN.ToList();
                ParentGrid.DataContext = LiefererListe;
            }
            else if (FilterListLNR.Any())
            {
                LiefererListe = FilterListLNR.ToList();
                ParentGrid.DataContext = LiefererListe;
            }
            else //wenn nicht Lade neu und zeige alle Inhalte an
            {
                LoadDelivererfromDB(ParentGrid, ctx);
            }
        }
    }


}
