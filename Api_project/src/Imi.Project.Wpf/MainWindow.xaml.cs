using Imi.Project.Wpf.ApiResponseModels.Category;
using Imi.Project.Wpf.ApiResponseModels.Fish;
using Imi.Project.Wpf.ApiResponseModels.OriginCountry;
using Imi.Project.Wpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IApiService _apiService;
        private readonly IHttpClientFactory _httpClientFactory;

        bool _isBusy;
        public MainWindow(IHttpClientFactory httpClientFactory, IApiService fishApiService)
        {
            InitializeComponent();
            _apiService = fishApiService;
            _httpClientFactory = httpClientFactory;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartDisplay();
            Clear();
            PopulateListBoxFishes();
        }
        private async void PopulateListBoxFishes()
        {
            lstProducts.ItemsSource = null;
            var fishApiResponse = await _apiService.GetFishes();
            if (fishApiResponse.IsSuccess)
            {
                lstProducts.ItemsSource = fishApiResponse.Data;

            }
            else
            {
                MessageBox.Show(fishApiResponse.ErrorMessage);
            }
        }

        private void StartDisplay()
        {
            txtName.IsEnabled = false;
            txtPrice.IsEnabled = false;
            txtMaxGewicht.IsEnabled = false;
            txtMinGewicht.IsEnabled = false;
            lblCategory.IsEnabled = false;
            lblDateOfArrival.IsEnabled = false;
            lblOriginCountry.IsEnabled = false;
            lblCategory.Visibility = Visibility.Visible;
            lblOriginCountry.Visibility = Visibility.Visible;
            cmbCategory.Visibility = Visibility.Hidden;
            cmbCountries.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Hidden;
            lblCategories.Visibility = Visibility.Hidden;
            lblCountries.Visibility = Visibility.Hidden;
            dptDateOfArrival.Visibility = Visibility.Hidden;
            lblDate.Visibility = Visibility.Hidden;
            btnDelet.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnNew.IsEnabled = true;
            lstProducts.IsEnabled = true;
        }

        private async void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstProducts.SelectedItem != null)
            {
                ShowDetail();
                var selectedFish=(FishApiResponse)lstProducts.SelectedItem;
                var fish = await _apiService.GetById(selectedFish.Id);
                if (fish.IsSuccess)
                {
                    txtName.Text = fish.Data.Name;
                    txtPrice.Text = $"{fish.Data.Price} : €";
                    txtMaxGewicht.Text = $"{fish.Data.MaxWeight} kg";
                    txtMinGewicht.Text = $"{fish.Data.MinWeigth} kg";
                    lblCategory.Content = fish.Data.CategoryName;
                    lblOriginCountry.Content = fish.Data.OriginCountryName;
                    lblDateOfArrival.Content = fish.Data.DateOfArrival;
                    if (fish.Data.ImagePath != null)
                    {
                        BitmapImage thumbnail = new BitmapImage();
                        thumbnail.BeginInit();
                        thumbnail.UriSource = new Uri(fish.Data.ImagePath);
                        thumbnail.EndInit();
                        imgFish.Source = thumbnail;
                    }
                }
                else
                {
                    MessageBox.Show(fish.ErrorMessage,"Foutmelding",MessageBoxButton.OK,MessageBoxImage.Error) ;
                }
            


            }
        }

        private void ShowDetail()
        {
           
            btnDelet.IsEnabled = true;
            btnEdit.IsEnabled = true;
            btnNew.IsEnabled = true;
        }
        private void Clear()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtMaxGewicht.Text = string.Empty;
            txtMinGewicht.Text = string.Empty;
            lblOriginCountry.Content = string.Empty;
            lblCategory.Content = string.Empty;
            lblDateOfArrival.Content = string.Empty;
            imgFish.Source = null;
            cmbCategory.ItemsSource = null;
            cmbCountries.ItemsSource = null;

        }

        private void NewOrEditDisplay()
        {
            txtName.IsEnabled = true;
            txtPrice.IsEnabled = true;
            txtMaxGewicht.IsEnabled = true;
            txtMinGewicht.IsEnabled = true;
            cmbCategory.Visibility = Visibility.Visible;
            cmbCountries.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Visible;
            lblDate.Visibility = Visibility.Visible;
            dptDateOfArrival.Visibility = Visibility.Visible;
            dptDateOfArrival.SelectedDate = DateTime.Now;
            btnDelet.IsEnabled = false;
            btnEdit.IsEnabled = false;
            btnNew.IsEnabled = false;
            lstProducts.IsEnabled = false;

        }
        private async void PopulateCmb()
        {
            var categoryResponse = await _apiService.GetCategories();
            if (categoryResponse.IsSuccess)
            {
                cmbCategory.ItemsSource = categoryResponse.Data;
                cmbCategory.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show(categoryResponse.ErrorMessage, "Foutmelding",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var originCountryResponse = await _apiService.GetCountries();
            if (originCountryResponse.IsSuccess)
            {
                cmbCountries.ItemsSource = originCountryResponse.Data;
                cmbCountries.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show(originCountryResponse.ErrorMessage, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnNew_Click(object sender, RoutedEventArgs e)
        {
            lblCategory.Visibility = Visibility.Hidden;
            lblOriginCountry.Visibility = Visibility.Hidden;
            lblDateOfArrival.Visibility= Visibility.Hidden;
           _isBusy = true;
            Clear();
            NewOrEditDisplay();
            PopulateCmb();

        }

        private async void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                var chosenProduct = (FishApiResponse)lstProducts.SelectedItem;
                if (MessageBox.Show("Ben je zeker ?", "verwijderen item", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                   var request= await _apiService.Delete(chosenProduct.Id);
                    if (request.IsSuccess)
                    {
                        MessageBox.Show("Vis wordt met successful verwijderd");
                        Clear();
                        StartDisplay();
                        PopulateListBoxFishes();
                    }
                    else
                    {
                        MessageBox.Show(request.ErrorMessage, "Foutmelding",MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }


            }
            else
            {
                MessageBox.Show("Geleive select");
            }
        }

        private async void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            StartDisplay();
            PopulateListBoxFishes();
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (_isBusy==true)
            {
                try
                {
                    var newFish = new FishApiRequest();
                    newFish.Name = txtName.Text;
                    newFish.Price = decimal.Parse(txtPrice.Text);
                    newFish.MaxWeight = decimal.Parse(txtMaxGewicht.Text);
                    newFish.MinWeigth = decimal.Parse(txtMinGewicht.Text);
                    newFish.CategoryId = ((CategroyApiResponse)cmbCategory.SelectedItem).Id;
                    newFish.OriginCountryId = ((OriginCountryApiResponse)cmbCountries.SelectedItem).Id;
                    newFish.DateOfArrival = (DateTime)dptDateOfArrival.SelectedDate;
                    newFish.UrlImage = "images/default.jpg";
                   var request= await _apiService.Create(newFish);
                    if (request.IsSuccess)
                    {
                        MessageBox.Show("Vis wordt met successful toegevoegd");

                    }
                    else
                    {
                        MessageBox.Show(request.ErrorMessage,"Foutmelding",MessageBoxButton.OK,MessageBoxImage.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             


            }
            else
            {
                try
                {
                    var chosenProduct = new FishApiRequest();
                    chosenProduct.Id = ((FishApiResponse)lstProducts.SelectedItem).Id;
                    chosenProduct.Name = txtName.Text;
                    chosenProduct.Price = decimal.Parse(txtPrice.Text);
                    chosenProduct.MaxWeight = decimal.Parse(txtMaxGewicht.Text);
                    chosenProduct.MinWeigth = decimal.Parse(txtMinGewicht.Text);
                    chosenProduct.CategoryId = ((CategroyApiResponse)cmbCategory.SelectedItem).Id;
                    chosenProduct.OriginCountryId = ((OriginCountryApiResponse)cmbCountries.SelectedItem).Id;
                    chosenProduct.DateOfArrival= (DateTime)dptDateOfArrival.SelectedDate;
                    chosenProduct.UrlImage = ((FishApiResponse)lstProducts.SelectedItem).ImagePath;
                   var requset= await _apiService.Update(chosenProduct);
                    if (requset.IsSuccess)
                    {
                        MessageBox.Show("Vis wordt met successful gewijzigd");
                    }
                    else
                    {
                        MessageBox.Show(requset.ErrorMessage, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              

            }

            Clear();
            StartDisplay();
            PopulateListBoxFishes();

        }

        private async void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                var selectedFish = (FishApiResponse)lstProducts.SelectedItem;
                var fish = await _apiService.GetById(selectedFish.Id);
                if (fish.IsSuccess)
                {
                    txtName.Text = fish.Data.Name;
                    txtPrice.Text = fish.Data.Price;
                    txtMaxGewicht.Text = fish.Data.MaxWeight;
                    txtMinGewicht.Text = fish.Data.MinWeigth;
                    lblCategory.Content = fish.Data.CategoryName;
                    lblOriginCountry.Content = fish.Data.OriginCountryName;
                    lblDateOfArrival.Content = fish.Data.DateOfArrival;
                    if (fish.Data.ImagePath != null)
                    {
                        BitmapImage thumbnail = new BitmapImage();
                        thumbnail.BeginInit();
                        thumbnail.UriSource = new Uri(fish.Data.ImagePath);
                        thumbnail.EndInit();
                        imgFish.Source = thumbnail;
                    }
                }
                else
                {
                    MessageBox.Show(fish.ErrorMessage, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                _isBusy = false;
                NewOrEditDisplay();
                PopulateCmb();

            }
            else
            {
                MessageBox.Show("Geleive Selected item", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
           await _apiService.Logout();
            var newForm = new Login(_httpClientFactory, _apiService);
            newForm.Show();
            this.Close();
        }
    }
}
