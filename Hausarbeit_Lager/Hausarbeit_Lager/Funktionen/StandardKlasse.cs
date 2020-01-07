using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Hausarbeit_Lager.Funktionen
{
    public class StandardKlasse
    {
        public static void ClearTBX(TextBox[] textBoxes)
        {
            //alle Inhalte der Textboxen leeren
            for (int i=0;i<textBoxes.Length;i++)
            {
                textBoxes[i].Clear();
            }
        }

        internal static bool Pruefe(TextBox[] textBoxes)
        {
            //Prüfe ob eine Eingabe vorliegt
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
