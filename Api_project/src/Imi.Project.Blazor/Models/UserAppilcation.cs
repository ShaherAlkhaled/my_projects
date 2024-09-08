using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class UserAppilcation
    {

        [Required(ErrorMessage = "Gelieve Wachtwoord in te vullen")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Gelieve email in te vullen")]
        [DataType(DataType.EmailAddress, ErrorMessage = ("Gelieve geldige email in te vullen"))]
        public string Email { get; set; }
        public string Token { get; set; }

    }
}
