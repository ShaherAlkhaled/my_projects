using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Validators
{
    public class LoginsValidator: AbstractValidator<User>
    {
        public LoginsValidator()
        {
           

            RuleFor(login => login.Email)
                .NotEmpty()
                    .WithMessage("Email is verplicht")
                .EmailAddress()
                    .WithMessage("Gelieve geldige email in te vullen");

            RuleFor(login => login.Password)
                .NotEmpty()
                    .WithMessage("Wachtwoord is verplicht");
        }
    }
}
