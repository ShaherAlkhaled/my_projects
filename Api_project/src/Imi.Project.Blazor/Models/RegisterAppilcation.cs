using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class RegisterAppilcation
    {
        [Required(ErrorMessage = "Gelieve  gebruikernaam in te vullen")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Gelieve  email in te vullen")]
        [DataType(DataType.EmailAddress, ErrorMessage = ("Gelieve geldige email in te vullen"))]

        public string Email { get; set; }

        [Required(ErrorMessage = "Gelieve Wachtwoord in te vullen")]
        [DataType(DataType.Password, ErrorMessage = ("Gelieve Wachtwoord in te vullen"))]


        public string Password { get; set; }

        [Required(ErrorMessage = "Gelieve Wachtwoord in te vullen")]
        [DataType(DataType.Password, ErrorMessage = ("Gelieve Wachtwoord in te vullen"))]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Gelieve uw geboortedatum in te vullen")]
        [DataType(DataType.DateTime, ErrorMessage = ("Gelieve uw geboortedatum in te vullen"))]
        public DateTime BirthDate { get; set; } = new DateTime(2001, 09, 01);
        [Required]

        public bool HasApprovedTermsAndConditions { get; set; }
    }
}
