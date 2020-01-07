using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausarbeit_Lager.Funktionen
{
    public class TempCust
    {
        public static LagerverwaltungContext ctx = new LagerverwaltungContext();
        public static string GetNow()
        {
            return DateTime.Now.ToLongDateString();
        }
        public static string GetCustomerName(int CompanyNR)
        {
            Kunde kunde = ctx.Kunde.Where(x => x.KundenNr.Equals(CompanyNR)).FirstOrDefault();
            return kunde.KundenName;
        }
        public static string GetCustomerAdresse(int CompanyNR)
        {
            Kunde kunde = ctx.Kunde.Where(x => x.KundenNr.Equals(CompanyNR)).FirstOrDefault();
            return kunde.Adresse;
        }
        public static string GetOrtPlz(int CompanyNR)
        {
            Kunde kunde = ctx.Kunde.Where(x => x.KundenNr.Equals(CompanyNR)).FirstOrDefault();
            string Ort = kunde.Ort;
            string PLZ = kunde.PLZ;
            string OrtPlz = PLZ+ " " + Ort;
            return OrtPlz;
        }

        public static string GetProductName(int ArtikelNummer)
        {
            Waren artikel = ctx.Waren.Where(x=>x.ArtikelNr.Equals(ArtikelNummer)).FirstOrDefault();
            return artikel.Produkte.ProduktName;
        }
        
        public static decimal GetProductValue(int ArtikelNummer)
        {
            Waren artikel = ctx.Waren.Where(x => x.ArtikelNr.Equals(ArtikelNummer)).FirstOrDefault();
            return Convert.ToDecimal(artikel.Produkte.ProduktWert);
        }
        public static decimal GetSum(int Value, decimal ProductValue)
        {
            return Value * ProductValue;
        }
    }
}
