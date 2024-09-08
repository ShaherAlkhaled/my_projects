using Imi.Project.Wpf.ApiResponseModels.Account;
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
using System.Windows.Shapes;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       private readonly IApiService _apiService;
        IHttpClientFactory _httpClientFactory;

        public Login(IHttpClientFactory httpClientFactory, IApiService apiService)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
           
            _apiService = apiService;
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
           
                LoginUserApiRequest loginUser = new LoginUserApiRequest();
                loginUser.Email = txtEmail.Text;
                loginUser.Password = txtPassword.Password;
              var request= await _apiService.Login(loginUser);
            if (request.IsSuccess)
            {
                var newForm = new MainWindow(_httpClientFactory, _apiService);
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(request.ErrorMessage,"Foutmelding",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
               
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Register(_httpClientFactory,_apiService);
            newForm.Show();
            this.Close();
        }
    }
}
