using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Mobile.Domain
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]

        public string ConfirmPassword { get; set; }

        [Required]

        public DateTime BirthDate { get; set; }
        [Required]

        public bool HasApprovedTermsAndConditions { get; set; }

    }
}
