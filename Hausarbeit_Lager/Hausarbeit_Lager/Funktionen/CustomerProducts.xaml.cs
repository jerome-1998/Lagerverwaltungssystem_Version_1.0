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
    /// Interaktionslogik für CustomerProducts.xaml
    /// </summary>
    public partial class CustomerProducts : Page
    {
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        MainWindow mainWindow;
        public CustomerProducts(MainWindow wnd)
        {
            InitializeComponent();

            mainWindow = wnd;
        }

        private void Cbxchoosecustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Kunde zuweisen
            Kunde kunde = (Kunde)cbxchoosecustomer.SelectedItem;
            if(kunde!=null)
            {
                List<Produkte> prodListe = kunde.Produkte.ToList();
                               

                foreach (Produkte p in prodListe)
                {
                    //Button nur aktivieren wenn dem Kunden das Produkt nicht zugewiesen wurde
                    if (p.Equals((Produkte)comboboxproduct.SelectedItem))
                    {
                        btnCustomerProduct.IsEnabled = false;
                        break;
                    }
                    else
                    {
                        if (cbxchoosecustomer.SelectedItem != null && comboboxproduct.SelectedItem != null)
                        {
                            btnCustomerProduct.IsEnabled = true;
                        }
                        else
                        {
                            btnCustomerProduct.IsEnabled = false;
                        }
                    }
                }
            }

        }

        private void BtnCustomerProduct_Click(object sender, RoutedEventArgs e)
        {
            if (comboboxproduct.SelectedItem != null && cbxchoosecustomer.SelectedItem != null)
            {
                //Dem Kunden das gewählte Produkt zuweisen
                Produkte produkte = (Produkte)comboboxproduct.SelectedItem;
                Kunde kunde= (Kunde)cbxchoosecustomer.SelectedItem;
                kunde.Produkte.Add(produkte);
                ctx.SaveChanges();
                btnCustomerProduct.IsEnabled = false;
            }
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            //zurück
            mainWindow.Tohome();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Daten laden
            ctx = new LagerverwaltungContext();
            ParentGrid.DataContext = ctx.Kunde.ToList();
            comboboxproduct.DataContext = ctx.Produkte.ToList();
        }
    }
}
