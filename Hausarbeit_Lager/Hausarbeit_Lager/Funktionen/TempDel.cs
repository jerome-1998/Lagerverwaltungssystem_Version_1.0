using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausarbeit_Lager.Funktionen
{
	
    public class TempDel
    {
        public static LagerverwaltungContext ctx = new LagerverwaltungContext();

        public static string GetNow()
        {
            return DateTime.Now.ToLongDateString();
        }
        public static string GetDelivererName(int CompanyNR)
        {
            Lieferer lieferer= ctx.Lieferer.Where(x => x.LiefererNR.Equals(CompanyNR)).FirstOrDefault();
            return lieferer.LiefererName;
        }
        public static string GetDelivererAdresse(int CompanyNR)
        {
            Lieferer lieferer= ctx.Lieferer.Where(x => x.LiefererNR.Equals(CompanyNR)).FirstOrDefault();
            return lieferer.Adresse;
        }
        public static string GetOrtPlz(int CompanyNR)
        {
            Lieferer lieferer= ctx.Lieferer.Where(x => x.LiefererNR.Equals(CompanyNR)).FirstOrDefault();
            string Ort = lieferer.Ort;
            string PLZ = lieferer.PLZ;
            string OrtPlz = PLZ + " " + Ort;
            return OrtPlz;
        }

        public static string GetProductName(int ArtikelNummer)
        {
            Waren artikel = ctx.Waren.Where(x => x.ArtikelNr.Equals(ArtikelNummer)).FirstOrDefault();
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
