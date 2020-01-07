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

namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        MainWindow mainWindow;

        public Home(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        public Home(MainWindow wnd,string Username)
        {
            InitializeComponent();
            tblloginas.Text = Username;

            mainWindow = wnd;
        }
        
        #region Clickevents
        //wechsle zu den angewähleten Seiten bzw beende Programm
        private void btnhometotalstock_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.TOtotalinv();
        }

        private void btnhomeleastwas_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Toleastwas();
        }

        private void Btnhomenewcustomer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToAddCustomer();
        }

        private void Btnhomeshowcustomer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToShowCustomer();
        }

        private void Btnhomenewdelieverer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToAddDeliverer();
        }
               
        private void Btnhomeorderdeliver_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToGoodsreceipt();
        }

        private void Btnhomeordersend_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToGoodsIssue();
        }

        private void Btnhomeaddnewgoods_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.TonewGoods();            
        }

        private void Btnhomedeletecustomer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToDeleteCustomer();
        }

        private void Btnhomedeletedeliverer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToDeleteDeliverer();
        }

        private void Btnhomedeleteproducts_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToDeleteProducts();
        }

        private void Btnhomedelieverer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToShowDeliverer();
        }

        private void Btnhomechangedeliverer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToCustomizeDeliverer();
        }

        private void Btnhomechangecustomer_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToCustomizeCustomer();
        }

        private void Btnhomechangegoods_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToCustomizeProducts();
        }


        private void Mihomeexit_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Tomainmenue();
        }

        private void MihomechangePW_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToChangePassword(tblloginas.Text);
        }

        private void Btnhomeuebersicht_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToUebersicht();
        }

        private void Mihomeclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
               
        private void Btnhomecustomerproducts_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.toCustomerProducts();
        }

        private void Btnhomedelivererproducts_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.toDelivererProducts();
        }

        #endregion Clickevents
    }
}

