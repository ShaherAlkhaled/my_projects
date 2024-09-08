using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class FishItem:BaseEntity
    {
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Gelieve category  te keuzen")]

        public long CategoryId { get; set; }
        public string OriginCountryName { get; set; }

        [Required(ErrorMessage = "Gelieve land  te keuzen")]

        public long OriginCountryId { get; set; }
        public string UrlImage { get; set; }
        [Required(ErrorMessage = "Gelieve prijs in te vullen")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Gelieve max gewecht in te vullen")]

        public decimal MaxWeight { get; set; }
        [Required(ErrorMessage = "Gelieve min gewecht in te vullen")]


        public decimal MinWeigth { get; set; }
        [Required(ErrorMessage = "Gelieve datum in te vullen")]

        public DateTime DateOfArrival { get; set; } = DateTime.Now;
        public List<FishProcessing> FishProcessings { get; set; }
        public List<CheckBoxModel> Properties { get; set; }
        public List<SelectListItem> CategoriesList { get; set; }
        public List<SelectListItem> CountriesList { get; set; }
        public List<long> FishProcessingIds { get; set; }


    }
}
