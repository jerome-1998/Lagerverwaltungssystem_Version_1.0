using Hausarbeit_Lager.Funktionen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;


namespace Hausarbeit_Lager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        //Seiten und DatenbankContexte erstellen
        LagerverwaltungContext ctx = new LagerverwaltungContext();
        deleteProducts DeleteProducts;
        deleteCustomer DeleteCustomer;
        addCustomer AddCustomer;
        Loginpage loginpage;
        Hauptmenue hauptmenue;
        Registration registration;
        Home home;
        totalinventory totalInventory;
        leastwas leastWas;
        showCustomer ShowCustomer;
        addDeliverer AddDeliverer;
        goodsReceipt GoodsReceipt;
        goodsIssue GoodsIssue;
        addnewGoods AddnewGoods;
        showDeliverer ShowDeliverer;
        deleteDeliverer DeleteDeliverer;
        customizeDeliverer CustomizeDeliverer;
        customizeThisDeliverer CustomizeThisDeliverer;
        customizeCustomer CustomizeCustomer;
        customizeThisCustomer CustomizeThisCustomer;
        customizeProducts CustomizeProducts;
        CustomizeThisProduct CustomizeThisProduct;
        ChangePassword changePassword;
        uebersichtBestellungen uebersichtBestellungen;
        CustomerProducts customerProducts;
        DelivererProducts delivererProducts;

        public MainWindow()
        {

            InitializeComponent();

            //Uhrzeit, aktuallisiere die uhrzeit jede Sekunde
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0,0,1),
                DispatcherPriority.Normal,
                delegate {
                    TimeText.FontWeight=FontWeights.Bold;
                    TimeText.Text = DateTime.Now.ToString("dd/MMMM/yyyy | HH:mm:ss");
                },
                this.Dispatcher);
            //Initialisiere die SeitenContexte
            loginpage = new Loginpage(this);
            hauptmenue = new Hauptmenue(this);
            registration = new Registration(this);
            home = new Home(this);
            totalInventory = new totalinventory(this);
            leastWas = new leastwas(this);
            AddCustomer = new addCustomer(this);
            ShowCustomer = new showCustomer(this);
            AddDeliverer = new addDeliverer(this);
            GoodsReceipt = new goodsReceipt(this);
            GoodsIssue = new goodsIssue(this);
            AddnewGoods = new addnewGoods(this);
            DeleteCustomer = new deleteCustomer(this);
            DeleteDeliverer = new deleteDeliverer(this);
            DeleteProducts = new deleteProducts(this);
            ShowDeliverer = new showDeliverer(this);
            CustomizeDeliverer = new customizeDeliverer(this);
            CustomizeCustomer = new customizeCustomer(this);
            CustomizeProducts = new customizeProducts(this);
            uebersichtBestellungen = new uebersichtBestellungen(this);
            customerProducts = new CustomerProducts(this);
            delivererProducts = new DelivererProducts(this);
            //Hauptmenü anzeigen
            mainframe.Content = hauptmenue;
        }

        //Methoden, welche die entsprechenden Seiten aufrufen
        public void Tologinpage()
        {
            mainframe.Content = loginpage;
        }
        public void Toregistrationpage()
        {
            mainframe.Content = registration;
        }
        public void Tomainmenue()
        {
            mainframe.Content = hauptmenue;
        }
        public void Tohome()
        {
            mainframe.Content = home;
        }
        public void Tohome(string Username)
        {
            home = new Home(this, Username);
            mainframe.Content = home;
        }
        public void TOtotalinv()
        {
            mainframe.Content = totalInventory;
        }
        public void Toleastwas()
        {
            mainframe.Content = leastWas;
        }
        
        public void CloseHomeSearch()
        {
            //homesuche.Visibility = Visibility.Hidden;
        }

        public void ToAddCustomer()
        {
            mainframe.Content = AddCustomer;
        }
        public void ToShowCustomer()
        {
            mainframe.Content = ShowCustomer;
        }
        public void ToAddDeliverer()
        {
            mainframe.Content = AddDeliverer;
        }
        public void ToGoodsreceipt()
        {
            mainframe.Content = GoodsReceipt;
        }
        public void ToGoodsIssue()
        {
            mainframe.Content = GoodsIssue;
        }
        public void TonewGoods()
        {
            mainframe.Content = AddnewGoods;
        }
        public void ToDeleteCustomer()
        {
            mainframe.Content = DeleteCustomer;
        }
        public void ToDeleteDeliverer()
        {
            mainframe.Content = DeleteDeliverer;
        }
        public void ToDeleteProducts()
        {
            mainframe.Content = DeleteProducts;
        }
        public void ToShowDeliverer()
        {
            mainframe.Content = ShowDeliverer;
        }
        public void ToCustomizeDeliverer()
        {
            mainframe.Content = CustomizeDeliverer;
        }
        public void ToCustomizeThisDeliverer(int DelivererID)
        {
            CustomizeThisDeliverer = new customizeThisDeliverer(this, DelivererID);
            mainframe.Content = CustomizeThisDeliverer;
        }
        public void ToCustomizeCustomer()
        {
            mainframe.Content = CustomizeCustomer;
        }
        public void ToCustomizeThisCustomer(int CustomerID)
        {
            CustomizeThisCustomer = new customizeThisCustomer(this, CustomerID);
            mainframe.Content = CustomizeThisCustomer;
        }
        public void ToCustomizeProducts()
        {
            mainframe.Content = CustomizeProducts;
        }
        public void ToCustomizeThisProduct(int ProductID)
        {
            CustomizeThisProduct = new CustomizeThisProduct(this,ProductID);
            mainframe.Content = CustomizeThisProduct;
        }
        public void ToChangePassword(string username)
        {
            changePassword = new ChangePassword(this,username);
            mainframe.Content = changePassword;
        }
        public void ToUebersicht()
        {
            mainframe.Content = uebersichtBestellungen;
        }
        public void toCustomerProducts()
        {
            mainframe.Content = customerProducts;
        }
        public void toDelivererProducts()
        {
            mainframe.Content = delivererProducts;
        }

    }
}
