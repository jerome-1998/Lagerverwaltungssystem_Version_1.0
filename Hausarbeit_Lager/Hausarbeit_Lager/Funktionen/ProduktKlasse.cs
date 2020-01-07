using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Hausarbeit_Lager.Funktionen
{
    class ProduktKlasse
    {
        //DatenbankContext und Liste zuweisen
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        public List<Waren> wList;

        //Daten aus Datenbank laden
        internal void LoadFromDB(Grid ParentGrid, LagerverwaltungContext ctx)
        {
            ctx = new LagerverwaltungContext();
            wList= ctx.Waren.ToList();
            ParentGrid.DataContext = wList.OrderBy(x=>x.ArtikelNr);
        }

        //Produkte in Datenbank hinzufügen
        internal void ProdukteHinzufuegen(int ANR, int PNR, float VAL, string PN, LagerverwaltungContext ctx)
        {
            //lege Produkt und Ware an
            Waren neueWare = new Waren();
            Produkte neuesProdukt = new Produkte();
            //Fülle alle Daten aus
            neueWare.ArtikelNr = ANR;
            neueWare.AktBestand = 0;
            neueWare.ProduktNummer = PNR;
            neuesProdukt.ProduktNummer = PNR;
            neuesProdukt.ProduktName = PN;
            neuesProdukt.ProduktWert = VAL;
            //füge Daten in Datenbank ein
            ctx.Produkte.Add(neuesProdukt);
            ctx.Waren.Add(neueWare);
            ctx.SaveChanges();
        }

        //Suchfunktion
        internal void ProduktSuche(string suche, List<Waren> WarenListe, Grid parentGrid)
        {            
            //Filterlisten erstellen
            var finditemName = WarenListe.Where(x => x.Produkte.ProduktName.ToString().ToLower().Contains(suche.ToLower()));
            var finditemNummer = WarenListe.Where(x => x.ArtikelNr.ToString().ToLower().StartsWith(suche.ToLower()));

            //Wenn Filterlisten Inhalte haben, zeige sie an
            if (finditemName.Any())
            {
                WarenListe = finditemName.ToList();
                parentGrid.DataContext = WarenListe;
            }
            else if (finditemNummer.Any())
            {
                WarenListe = finditemNummer.ToList();
                parentGrid.DataContext = WarenListe;
            }
            else//ansonsten lade daten neu aus der Datenbank
            {
                LoadFromDB(parentGrid,ctx);
                WarenListe = new List<Waren>();
            }
             
        }


    }
}
