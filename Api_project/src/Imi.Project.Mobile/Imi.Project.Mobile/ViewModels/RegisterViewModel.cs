using FreshMvvm;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class RegisterViewModel: FreshBasePageModel
    {
        protected readonly IAccountService _registerService;
        protected readonly RegisterValidator validater;

        public RegisterViewModel(RegisterValidator validater, IAccountService registerService)
        {
            this.validater = validater;
            _registerService = registerService;
        }


        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                RaisePropertyChanged();
            }
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

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; RaisePropertyChanged(); }
        }


        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                value = new DateTime(2000, 10, 10);
                birthDate = value;
                RaisePropertyChanged();
            }
        }

        private bool hasApprovedTermsAndConditions;

        public bool HasApprovedTermsAndConditions
        {
            get { return hasApprovedTermsAndConditions; }
            set
            {
                hasApprovedTermsAndConditions = value;
                RaisePropertyChanged();
            }
        }


        private string userNameError;
        public string UserNameError
        {
            get { return userNameError; }
            set
            {
                userNameError = value;
                RaisePropertyChanged();
            }
        }
        private string confirmPasswordError;
        public string ConfirmPasswordError
        {
            get { return confirmPasswordError; }
            set
            {
                confirmPasswordError = value;
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


        private string birthDateError;
        public string BirthDateError
        {
            get { return birthDateError; }
            set
            {
                birthDateError = value;
                RaisePropertyChanged();
            }
        }
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            UserName = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
            BirthDate = DateTime.Now;
            DefaultLableErrorState();

        }
        public ICommand RegisterCommand => new Command(async () =>
        {
            var register = new Register
            {
               UserName=this.UserName,
               Email=this.Email,
               Password=this.Password,
               ConfirmPassword=this.ConfirmPassword,
               BirthDate=this.BirthDate,
               HasApprovedTermsAndConditions=this.HasApprovedTermsAndConditions,
            };


            var validationResult = validater.Validate(register);


            DefaultLableErrorState();

            if (validationResult.IsValid)
            {
                try
                {
                await _registerService.Register(register);
                await CoreMethods.DisplayAlert("Succes", $" Uw registratie met gebruikersnaam {UserName} is succes", "Ok");

                await CoreMethods.PopPageModel(false);
                }catch (Exception ex)
                {
                    await CoreMethods.DisplayAlert("Error", "Er is fout opgetreden :\n Gebruiker bestaat of network fout", "Ok");

                }
              
            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    if (failure.PropertyName == nameof(Register.UserName))
                    {
                        UserNameError = failure.ErrorMessage;
                    }
                    else if (failure.PropertyName == nameof(Register.Email))
                    {
                        EmailError = failure.ErrorMessage;
                    }
                    else if (failure.PropertyName == nameof(Register.Password))
                    {
                        PasswordError = failure.ErrorMessage;
                    }
                    else if (failure.PropertyName == nameof(Register.ConfirmPassword))
                    {
                        ConfirmPasswordError = failure.ErrorMessage;
                    }
                    else if (failure.PropertyName == nameof(Register.BirthDate))
                    {
                        BirthDateError = failure.ErrorMessage;
                    }
                    else
                    {
                        throw new NotImplementedException($"The property {failure.PropertyName} is not handled in the viewmodel");
                    }
                }

            }


        });

        public ICommand GoBackCommand => new Command(async () => 
        {
           await CoreMethods.PopPageModel();
        });

        private void DefaultLableErrorState()
        {
            UserNameError = default;
            EmailError = default;
            PasswordError = default;
            ConfirmPasswordError = default;
            BirthDateError = default;
        }


    }
}
