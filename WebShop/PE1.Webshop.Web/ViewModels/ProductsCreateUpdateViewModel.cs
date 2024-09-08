using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PE1.Webshop.Web.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PE1.Webshop.Web.ViewModels
{
    public class ProductsCreateUpdateViewModel
    {

        [HiddenInput]
        public long? Id { get; set; }
        [DisplayName("Naam :")]
        [Required(ErrorMessage = "We need The Name of Product!")]
        public string Name { get; set; }

        [DisplayName("Merk:")]
        [Required(ErrorMessage = "We need The Brand of Product!")]
        public string Brand { get; set; }
        [DisplayName("Model:")]
        [Required(ErrorMessage = "We need The Model of Product!")]
        public string Model { get; set; }

        [DisplayName("Price:")]
        [Required(ErrorMessage = "We need The Price of Product!")]
        public decimal Price { get; set; }
        public int? Rating { get; set; }

        [DisplayName("Category:")]
        public long SelectedItem { get; set; }
        public List<SelectListItem> Items { get; set; }
        [DisplayName("Properties:")]
        public List<CheckboxModel> Properties { get; set; }

        [DataType(DataType.Upload)]

        public IFormFile Image { get; set; }


    }
}
