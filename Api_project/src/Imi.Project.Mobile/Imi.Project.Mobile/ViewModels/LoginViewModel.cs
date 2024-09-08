using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Validators;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Imi.Project.Mobile.ViewModels
{
    public class LoginViewModel: FreshBasePageModel
    {
        protected readonly IAccountService _loginService;
        protected readonly LoginsValidator validator;


        public LoginViewModel(IAccountService loginService)
        {
            _loginService = loginService;
            validator = new LoginsValidator();
        }


    

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged();
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged();
            }
        }
        private string emailError;
        public string EmailError
        {
            get { return emailError; }
            set
            {
                emailError = value;
                RaisePropertyChanged();
            }
        }

        private string passwordError;
        public string PasswordError
        {
            get { return passwordError; }
            set
            {
                passwordError = value;
                RaisePropertyChanged();
            }
        }
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            Email = "";
            Password = "";
            EmailError = default;
            PasswordError = default;
        }
        public ICommand LoginCommand => new Command(async () =>
        {
            var login = new User
            {
                Email = Email,
                Password = Password,
            };
           

            var validationResult = validator.Validate(login);


            EmailError = default;
            PasswordError = default;

            if (validationResult.IsValid)
            {
                try
                {
                   var token= await _loginService.Login(login);
                    if (CheckAccess(token))
                    {
                        await CoreMethods.DisplayAlert("Welkom", "Inloggen is succes ", "Ok");

                        await CoreMethods.PushPageModel<CategoriesViewModel>(false);
                    }
                    else
                    {
                        await CoreMethods.DisplayAlert("Error", "Sorry U hebt geen toegang naar deze app !!", "Ok");
                    }

                  
                }catch (Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", "Uw wachtwoord of email klopt niet ", "Ok");
                }
            

            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    if (failure.PropertyName == nameof(User.Email))
                    {
                        EmailError = failure.ErrorMessage;
                    }
                    else if (failure.PropertyName == nameof(User.Password))
                    {
                        PasswordError = failure.ErrorMessage;
                    }
                    else
                    {
                        throw new NotImplementedException($"The property {failure.PropertyName} is not handled in the viewmodel");
                    }
                }

            }


        });

        public ICommand RegisterCommand => new Command(async () =>
        {
            await CoreMethods.PushPageModel<RegisterViewModel>();
        });

        public ICommand UserImiCommand => new Command( () =>
        {

            Email = "user@imi.be";
            Password = "Test123?";
        });
        public ICommand RefUserImiCommand => new Command(() =>
        {

            Email = "refuser@imi.be";
            Password = "Test123?";
        });
        public ICommand AdminImiCommand => new Command(() =>
        {

            Email = "admin@imi.be";
            Password = "Test123?";
        });
        private bool CheckAccess(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.ReadJwtToken(token);

            var hasApprovedTermsAndConditions = securityToken.Claims.FirstOrDefault(c => c.Type == "HasApprovedTermsAndConditions")?.Value;
            var admin = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

            return hasApprovedTermsAndConditions == true.ToString() || admin == "Admin";
        }

    }
}
