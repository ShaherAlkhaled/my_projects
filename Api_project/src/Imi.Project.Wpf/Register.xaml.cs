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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private readonly IApiService _apiService;
        IHttpClientFactory _httpClientFactory;
        public Register(IHttpClientFactory httpClientFactory, IApiService apiService)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
            _apiService = apiService;
            dtBirthDate.SelectedDate = new DateTime(2001, 10, 20);
            Clear();
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegisterUserApiRequest registerUserApiRequest = new RegisterUserApiRequest();
                registerUserApiRequest.Username = txtUserName.Text;
                registerUserApiRequest.Email = txtEmail.Text;
                registerUserApiRequest.Password = txtPassword.Password;
                registerUserApiRequest.ConfirmPassword = txtPasswordConfirm.Password;
                registerUserApiRequest.BirthDate = (DateTime)dtBirthDate.SelectedDate;
                registerUserApiRequest.HasApprovedTermsAndConditions = (bool)chAgreeWithCondition.IsChecked;
               var request= await _apiService.Register(registerUserApiRequest);
                if (request.IsSuccess)
                {
                var newForm = new Login(_httpClientFactory, _apiService);
                newForm.Show();
                this.Close();

                }
                else
                {
                    MessageBox.Show(request.ErrorMessage, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void Clear()
        {
            txtEmail.Text =String.Empty;
            txtPassword.Password = String.Empty;
            txtPasswordConfirm.Password = String.Empty;
            txtUserName.Text = String.Empty;
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Login(_httpClientFactory, _apiService);
            newForm.Show();
            this.Close();
        }
    }
}
