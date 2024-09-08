using Imi.Project.Wpf.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Account
{
    public class LoginUserApiRequest
    {
        [JsonPropertyName("email")]
        [Required]
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
    }
}
