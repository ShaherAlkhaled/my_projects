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

namespace Prb._2021_2.PE2.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Dictionary<string, decimal> drinks;
        decimal payPrice = 0;
        decimal coin;
        decimal countCoin = 0;
        decimal result;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblTotal.Content = "";
            lstSales.Items.Clear();
            lstBeverage.Items.Clear();
            drinks = new Dictionary<string, decimal>();
            drinks.Add("Coca Cola 33cl", 1.20M);
            drinks.Add("Coca Cola Zero 33cl", 1.20M);
            drinks.Add("Coca Cola Light 33cl", 1.20M);
            drinks.Add("Coca Cola Cherry 33cl", 1.20M);
            drinks.Add("Lepton tea 33cl", 1.20M);
            drinks.Add("Fanta orange 33cl", 1.30M);
            drinks.Add("Fanta zero 33cl", 1.30M);
            drinks.Add("Spa rood 50cl", 1.20M);
            drinks.Add("Spa blauw 50cl", 1.00M);
            drinks.Add("Spa water 33cl", 0.90M);
            drinks.Add("Friti 50cl", 1.50M);
            drinks.Add("Red bull super 33cl", 2.30M);
            drinks.Add("Red bull super 50cl", 4.00M);


            for (int i = 0; i < drinks.Count; i++)
            {
                string listDrinks = $"{drinks.Keys.ElementAt(i)} - €{drinks.Values.ElementAt(i)}";
                lstBeverage.Items.Add(listDrinks);
            }

            DoSeeding();
        }
        private void DoSeeding()
        {

            lblBeverageDelivered.Content = "";
            lblChosenBeverage.Content = "";
            lblChosenBeverage_Copy1.Content = "";
            lblReturnChange.Content = "";
            lblToPay.Content =null;
            grpStep1.IsEnabled = true;
            grpStep2.IsEnabled = false;
            grpStep3A.IsEnabled = false;
            grpStep3B.IsEnabled = false;


        }

        private void btnConfirmBeverage_Click(object sender, RoutedEventArgs e)
        {
            if (lstBeverage.SelectedItem != null)
            {
                string chosDrinks = lstBeverage.SelectedItem.ToString();
                lblChosenBeverage.Content = chosDrinks;

                for (int i = 0; i < drinks.Count; i++)
                {
                    if (lstBeverage.SelectedIndex == i)
                    {
                        if (i == 12)
                        {
                            MessageBox.Show("Sorry! Red bull super 50cl is Op!", "Informatie", MessageBoxButton.OK, MessageBoxImage.Information);
                            DoSeeding();
                            return;
                        }
                        else
                        {
                            decimal drinkPrice = drinks.Values.ElementAt(i);
                            lblToPay.Content = drinkPrice.ToString("€#0.00");
                           
                        }
                        
                    }
                }
                grpStep1.IsEnabled = false;
                grpStep2.IsEnabled = true;
            }
          
        }

        private void btn2Euro_Click(object sender, RoutedEventArgs e)
        {
            coin = 2M;
            countCoin += coin;

            Calculate();
        }

        private void btn1Euro_Click(object sender, RoutedEventArgs e)
        {
            coin = 1M;
            countCoin += coin;
            Calculate();
        }

        private void btn50C_Click(object sender, RoutedEventArgs e)
        {
            coin = 0.50M;
            countCoin += coin;
            Calculate();
        }

        private void btn20C_Click(object sender, RoutedEventArgs e)
        {
            coin = 0.20M;
            countCoin += coin;
            Calculate();
        }

        private void btn10C_Click(object sender, RoutedEventArgs e)
        {
            coin = 0.10M;
            countCoin += coin;

            Calculate();
        }
        private void Calculate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            string hour = date.ToString("HH:mm:ss");
            string sales;
            string toPay = lblToPay.Content.ToString();
            toPay = toPay.Replace("€", " ");
            toPay = toPay.Trim();
            decimal.TryParse(toPay, out decimal payCoin);

            if (coin >= payCoin)
            {
                result = coin - payCoin;
                if (result == 0)
                {
                    lblBeverageDelivered.Content = lblChosenBeverage.Content;
                    sales = $" {hour} - {lblBeverageDelivered.Content.ToString()}";
                    lstSales.Items.Insert(0, sales);
                    lblToPay.Content = result.ToString("€#0.00");
                    lblReturnChange.Content = result.ToString("€#0.00");
                    TotalPrice();
                    grpStep3A.IsEnabled = true;
                    grpStep3B.IsEnabled = false;
                    grpStep1.IsEnabled = false;
                    grpStep2.IsEnabled = false;
                }
                else
                {

                    string reuterPrie = $" Teruggave = {result.ToString("€#0.00")}\n";


                    //decimal[] caculat = { 2M, 1M, 0.50M, 0.20M,0.20, 0.10M };
                    List<decimal> caculat = new List<decimal>();
                    caculat.Add(2m); caculat.Add(1m); caculat.Add(0.50m); caculat.Add(0.20m); caculat.Add(0.20m); caculat.Add(0.10m);

                    foreach (decimal choseCoin in caculat)
                    {


                        if (result - choseCoin < 0)
                        {
                            continue;
                        }
                        else if (result - choseCoin > 0)
                        {
                            result -= choseCoin;
                            reuterPrie += $"1 x {choseCoin.ToString("#0.0€")}\n";

                        }
                        else if (result - choseCoin == 0)
                        {
                            reuterPrie += $"1 x {choseCoin.ToString("#0.0€")}\n";
                            break;
                        }
                    }

                    lblReturnChange.Content = reuterPrie;
                    lblBeverageDelivered.Content = lblChosenBeverage.Content;
                    sales = $" {hour} - {lblBeverageDelivered.Content.ToString()}";
                    grpStep3A.IsEnabled = true;
                    grpStep3B.IsEnabled = true;
                    grpStep1.IsEnabled = false;
                    grpStep2.IsEnabled = false;
                    lstSales.Items.Insert(0, sales);
                    lblToPay.Content = 0.ToString("€#0.00");
                    TotalPrice();

                }
            }
            if (payCoin > coin)
            {
                decimal result = payCoin - coin;
                lblToPay.Content = result.ToString("€#0.00");

            }


        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (countCoin == 0)
            {
                DoSeeding();
            }
            else
            {
                string reuterPrie = $" Teruggave = {countCoin.ToString("€#0.00")}\n";

                List<decimal> caculat = new List<decimal>();
                caculat.Add(2m); caculat.Add(1m); caculat.Add(0.50m); caculat.Add(0.20m); caculat.Add(0.20m); caculat.Add(0.10m);

                foreach (decimal choseCoin in caculat)
                {


                    if (countCoin - choseCoin < 0)
                    {
                        continue;
                    }
                    else if (countCoin - choseCoin > 0)
                    {
                        countCoin -= choseCoin;
                        reuterPrie += $"1 x {choseCoin.ToString("#0.0€")}\n";

                    }
                    else if (countCoin - choseCoin == 0)
                    {
                        reuterPrie += $"1 x {choseCoin.ToString("#0.0€")}\n";
                        break;
                    }

                }
                lblReturnChange.Content = reuterPrie;
                grpStep1.IsEnabled = false;
                grpStep2.IsEnabled = false;
                grpStep3A.IsEnabled = false;
                grpStep3B.IsEnabled = true;

            }
        }

        private void btnBeverageAccepted_Click(object sender, RoutedEventArgs e)
        {
            if (result == 0)
            {
                DoSeeding();

            }
            else
            {
                grpStep1.IsEnabled = false;
                grpStep2.IsEnabled = false;
                grpStep3A.IsEnabled = false;
                grpStep3B.IsEnabled = true;
            }
        }

        private void btnChangeAccepted_Click(object sender, RoutedEventArgs e)
        {
            countCoin = 0;
            MessageBox.Show("Sorry! Er is geen wislgeld meer !", "Opletten", MessageBoxButton.OK, MessageBoxImage.Information);
            DoSeeding();
        }
        private void TotalPrice()
        {

            string deliver = lblBeverageDelivered.Content.ToString();  // breng in houd en to string 
            deliver = deliver.Trim();                             // zonder spatie 
            deliver = deliver.Replace(",", "");                   // coma weg 
            int number = deliver.Length;                          // lang van inhoud maar word de prijs *100 (bv.   1,20 wordt 120)
            deliver = deliver.Substring(number - 3, 3);              // laste 3 kinppen   en dat betekent de prijs  
            payPrice += decimal.Parse(deliver);                   // omzet naar decimal + standaard waarde (0)
            lblTotal.Content = (payPrice / 100).ToString("€#0.00");  // label totaal prijs invullen 
        }
    }
}
