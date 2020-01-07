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

namespace Hausarbeit_Lager.Funktionen
{
    /// <summary>
    /// Interaktionslogik für DelivererProducts.xaml
    /// </summary>
    public partial class DelivererProducts : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        MainWindow mainWindow;
        public DelivererProducts(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Btnproducttodeliverer_Click(object sender, RoutedEventArgs e)
        {
            if(comboboxproduct.SelectedItem!=null&&cbxdeliverer.SelectedItem!=null)
            {
                //Dem Lieferer das Produkt zuweisen
                Produkte produkte = (Produkte)comboboxproduct.SelectedItem;
                Lieferer lieferer = (Lieferer)cbxdeliverer.SelectedItem;
                lieferer.Produkte.Add(produkte);
                ctx.SaveChanges();
                btnproducttodeliverer.IsEnabled = false;
            }
            
        }

        private void Comboboxproduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //lieferer zuweisen
            Lieferer lieferer = (Lieferer)cbxdeliverer.SelectedItem;

            if(lieferer!=null)
            {
                List<Produkte> prodListe = lieferer.Produkte.ToList();

                foreach (Produkte p in prodListe)
                {
                    //Button nur aktivieren wenn dem Lieferer das Produkt noch nicht zugewiesen wurde
                    if (p.Equals((Produkte)comboboxproduct.SelectedItem))
                    {
                        btnproducttodeliverer.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        if (cbxdeliverer.SelectedItem != null && comboboxproduct.SelectedItem != null)
                        {
                            btnproducttodeliverer.IsEnabled = true;
                        }
                        else
                        {
                            btnproducttodeliverer.IsEnabled = false;
                        }
                    }
                }
            }
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten laden
            ctx = new LagerverwaltungContext();
            ParentGrid.DataContext = ctx.Lieferer.ToList();
            comboboxproduct.DataContext = ctx.Produkte.ToList();
        }
    }
}
