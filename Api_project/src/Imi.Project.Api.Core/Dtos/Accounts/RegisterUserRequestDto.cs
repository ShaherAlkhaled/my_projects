using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos.Accounts
{
    public class RegisterUserRequestDto
    {
        [Required]
        public string Username { get; set; }

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
