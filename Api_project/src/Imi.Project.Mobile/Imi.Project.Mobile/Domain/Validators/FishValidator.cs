using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Validators
{
    public class FishValidator: AbstractValidator<Fish>
    {
        public FishValidator()
        {


            RuleFor(fish => fish.Name)
                .NotEmpty()
                .WithMessage("Naam is verplicht");

            RuleFor(fish => fish.Price)
                .NotEmpty()
                .WithMessage("Prijs is verplicht");
            RuleFor(fish => fish.MaxWeight)
              .NotEmpty()
              .WithMessage("Maxgewicht is verplicht");
            RuleFor(fish => fish.MinWeigth)
              .NotEmpty()
              .WithMessage("Mingewicht is verplicht")
              .LessThan(fish => fish.MaxWeight).WithMessage("Mingewicht kan niet groter dan maxgegewicht");
            RuleFor(fish => fish.CategoryId)
            .NotNull()
            .WithMessage("Category is verplicht");
            RuleFor(fish => fish.OriginCountryId)
            .NotNull()
            .WithMessage("Afkomstig_Land is verplicht");
          
        }
    }
}
