using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Validators
{
    public class RegisterValidator: AbstractValidator<Register>
    {
        public RegisterValidator()
        {
            RuleFor(register => register.UserName)
               .MinimumLength(3)
                   .NotEmpty()
                    .WithMessage("Gebruikernaam is verplicht");
            RuleFor(register => register.Email)
                .NotEmpty()
                    .WithMessage("Email is verplicht")
                .EmailAddress()
                    .WithMessage("Gelieve geldige email in te vullen");

            RuleFor(register => register.Password)
                .NotEmpty()
                .WithMessage("Wachtwoord is verplicht")
                .MinimumLength(6)
                .WithMessage("De lengte van Wachtwoord moet 6 of meer.")
                .Matches(@"[A-Z]+").WithMessage("Uw wachtwoord moet minimaal één hoofdletter bevatten.")                
                .Matches(@"[a-z]+").WithMessage("Uw wachtwoord moet minimaal één kleine letter bevatten.")
                .Matches(@"[0-9]+").WithMessage("Uw wachtwoord moet minimaal één cijfer bevatten.")
                .Matches(@"[\!\?\*\.]+").WithMessage("Uw wachtwoord moet minimaal één (!? *.) bevatten.");

            RuleFor(register => register.ConfirmPassword)
                .NotEmpty()
                .WithMessage("Voer uw ConfirmPassword in")
                .MinimumLength(6)
                .WithMessage("Uw bevestigingswachtwoord moet gelijk zijn aan of groter zijn dan 6 tekens")
               .Equal(r=> r.Password)
               .WithMessage("Uw Bevestig wachtwoord moet gelijk zijn aan Wachtwoord")
                .Matches(@"[A-Z]+").WithMessage("Uw wachtwoord moet minimaal één hoofdletter bevatten.")
                .Matches(@"[a-z]+").WithMessage("Uw wachtwoord moet minimaal één kleine letter bevatten.")
                .Matches(@"[0-9]+").WithMessage("Uw wachtwoord moet minimaal één cijfer bevatten.")
                .Matches(@"[\!\?\*\.]+").WithMessage("Uw wachtwoord moet minimaal één (!? *.) bevatten.");


            RuleFor(register => register.BirthDate)
                .LessThan(DateTime.Today)
                    .WithMessage("Je geboortedatum moet in het verleden liggen");

        }
    }
    }
