using Imi.Project.Wpf.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Account
{
    public class RegisterUserApiRequest
    {
        [JsonPropertyName("username")]


        public string Username { get; set; }

        [JsonPropertyName("email")]



        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (ValidatorExtensions.IsValidEmailAddress(value) == false)
                {
                    throw new Exception("Gelieve geldig email in te vullen");
                }
                email = value;
            }
        }


        [JsonPropertyName("password")]

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (ValidatorExtensions.IsValidInput(value) == false)
                {
                    throw new Exception("Wachtwoord moet langer dan 6 karakters");
                }
                password = value;
            }
        }

        [JsonPropertyName("confirmPassword")]

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (ValidatorExtensions.IsSameInput(value, this.password) == false)
                {
                    throw new Exception("De wachtwoord is niet overeengekomen met confirm wachtwoord");
                }
                confirmPassword = value;
            }
        }
        [JsonPropertyName("birthDate")]

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (ValidatorExtensions.IsValidDateInput(value) == false)
                {
                    throw new Exception("Datum moet vroeger dan vandaag zijn");
                }
                birthDate = value;
            }
        }


        [JsonPropertyName("hasApprovedTermsAndConditions")]
        public bool HasApprovedTermsAndConditions { get; set; }

    }
}
