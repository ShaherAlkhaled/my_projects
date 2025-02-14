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

namespace Prb.Pe1.Facturatie.Wpf
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


        decimal net = 0M;
        decimal gross = 0M;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoStartUp();
        }

        private void DoStartUp()
        {

            DateTime date = DateTime.Today;
            dtpDate.SelectedDate = date;


            for (int i = 0; i <= 24; i++)
            {
                cmbStartHour.Items.Add(i);
                cmbEndHour.Items.Add(i);
            }
            cmbStartHour.SelectedItem = 7;
            cmbEndHour.SelectedItem = 16;
            txtHourRate.Text = 45.ToString();

            cmbVAT.Items.Add(6);
            cmbVAT.Items.Add(21);
            cmbVAT.SelectedItem = 21;


            //lblTatolGross.Content = "€ " + "0.00";
            btnRemove.IsEnabled = false;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (CheckPoint())
            {
                DateTime date = (DateTime)dtpDate.SelectedDate;
                int startHour = (int)cmbStartHour.SelectedItem;
                int endHour = (int)cmbEndHour.SelectedItem;
                decimal hourRate = decimal.Parse(txtHourRate.Text);
                int vat = (int)cmbVAT.SelectedItem;

                lstReuslt.Items.Add(Maketext(date, startHour, endHour, hourRate, vat));
                net += CalculateNetPrice(startHour, endHour, hourRate);
                gross += CalculateGross(startHour, endHour, hourRate, vat);
                DisplayLabelPrice();
             
            }


        }
        private void DisplayLabelPrice()
        {
            lblTotalNet.Content = net.ToString("€#,##0.00");
            lblTatolGross.Content = gross.ToString("€#,##0.00");

        }

        bool CheckPoint()
        {
            int startHour = (int)cmbStartHour.SelectedItem;
            int endHour = (int)cmbEndHour.SelectedItem;
            decimal controlRateHour;
            try
            {
                controlRateHour = decimal.Parse(txtHourRate.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Geef eerlijke uur tarief AUB",ex.Message);
                return false;
            }

            controlRateHour = decimal.Parse(txtHourRate.Text);

            if (dtpDate.SelectedDate == null)
            {
                MessageBox.Show("U moet de datum selecteren");
                dtpDate.Focus();
                return false;
            }
            else if (cmbStartHour.SelectedItem == null)
            {
                MessageBox.Show("U moet de startuur selecteren");
                cmbStartHour.Focus();
                return false;
            }

            else if (cmbEndHour.SelectedItem == null)
            {
                MessageBox.Show("U moet de Einduur selecteren");
                cmbEndHour.Focus();
                return false;
            }
            else if (txtHourRate.Text == null)
            {
                MessageBox.Show("U moet uur tarifen invullen");
                txtHourRate.Focus();
                return false;
            }
            else if (cmbVAT.SelectedItem == null)
            {
                MessageBox.Show("U moet BTW precentage selecteren");
                cmbVAT.Focus();
                return false;
            }
            else if (startHour >= endHour)
            {
                MessageBox.Show("Einduur moet groter dan startuur maar niet omgekeerd ");
                cmbStartHour.Focus();
                cmbEndHour.Focus();
                return false;
            }
            else if (controlRateHour <= 0)
            {
                MessageBox.Show("Uur tarief mag niet Nul of in Negative waarde zijn ");
                txtHourRate.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private decimal CalculateNetPrice(int startUur, int enidUur, decimal rateHour)
        {

            int workHour = enidUur - startUur;
            decimal net = workHour * rateHour;

            return net;
        }

        private decimal CalculateGross(int startUur, int enidUur, decimal rateHour, int vatPercentage)
        {

            int workHour = enidUur - startUur;
            decimal net = workHour * rateHour;
            decimal vatPrice = net * (decimal)vatPercentage / 100;
            decimal gross = net + vatPrice;

            return gross;

        }

        private string Maketext(DateTime date, int startHour, int endHour, decimal hourRate, int vat)
        {

            decimal net = CalculateNetPrice(startHour, endHour, hourRate);
            decimal gross = CalculateGross(startHour, endHour, hourRate, vat);
            string line = $"{date.ToString("dd/MM/yyyy")} {startHour}u - {endHour}u ({hourRate} €/ u): €{net.ToString("#,##0.00")} (€{gross.ToString("#,##0.00")} incl. {vat}% BTW)";
            
            return line;
        }







        private decimal ExtractPrice(string summary, bool vat)
        {
            string[] split = summary.Split();
            string price = vat ? split[split.Length - 4].Substring(2) : split[split.Length - 5].Substring(1);
            return decimal.Parse(price);
        }
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {


            if (MessageBox.Show("Ben je zeker ?", "verwijderen item", MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                
                string line = lstReuslt.SelectedItem.ToString();
                decimal removeNet = ExtractPrice(line, false);
                decimal removeGross = ExtractPrice(line, true);
                net -= removeNet;
                gross -= removeGross;
                DisplayLabelPrice();
                lstReuslt.Items.Remove(lstReuslt.SelectedItem);
                lstReuslt.SelectedIndex = 0;
                
            }
            else
            {
                MessageBox.Show("Selected Item is niet verwijderd", "verwijderen item", MessageBoxButton.OK, MessageBoxImage.Information);
            }


                
            
          

        }

        private void LstReuslt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstReuslt.SelectedItem != null)
            {
                
                btnRemove.IsEnabled = true;
                
            }
            else
            {
                btnRemove.IsEnabled = false;
            }

        }
    }
}
