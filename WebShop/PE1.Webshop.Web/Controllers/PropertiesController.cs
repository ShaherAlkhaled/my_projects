using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Data;
using PE1.Webshop.Web.Models;
using PE1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly WebShopDbContext _webShopDbContext;


        public PropertiesController(WebShopDbContext webShopDbContext)
        {
            _webShopDbContext = webShopDbContext;
        }
        public IActionResult ShowProperties()
        {
            var propertiesShowPropertiesViewModel = new PropertiesShowPropertiesViewModel();

            //fill the model
            propertiesShowPropertiesViewModel.Properties = _webShopDbContext.Properties.Select(p =>
                    new PropertiesShowDetailPropertyViewModel
                    {
                        PropertyId = p.Id,
                        PropertyName = p.Name
                    }
                );

            return View(propertiesShowPropertiesViewModel);
        }


        public IActionResult ShowDetailProperty(int id)
        {

            var propertiesShowDetailPropertyViewModel = new PropertiesShowDetailPropertyViewModel();
            var property = _webShopDbContext.Properties.FirstOrDefault(p => p.Id.Equals(id));
            propertiesShowDetailPropertyViewModel.PropertyId = property.Id;
            propertiesShowDetailPropertyViewModel.PropertyName = property.Name;
            return View(propertiesShowDetailPropertyViewModel);
        }

        public IActionResult ShowProductsThatHasThisProperty(int id)
        {
            var propertiesShowProductsThatHasThisProperty = new PropertiesShowProductsThatHasThisProperty();
            var property = _webShopDbContext.Properties.FirstOrDefault(p => p.Id.Equals(id));


            var products = _webShopDbContext
                .Products
                .Where(p => p.Property.Any(pr => pr.Id == id))
                .Select(p => new ProductsShowProductDetailViewModel
                {
                    ProductId = p.Id,
                    ProductName = $"{p.Brand} {p.Name} {p.Model}",
                    ProductPrice = p.Price.ToString("€ #0.00"),
                    ProductCategory = p.Category.Name,
                    ImagePath = p.ImageFileName,
                });

            if (property == null)
                return NotFound();


            propertiesShowProductsThatHasThisProperty.PropertyName = property.Name;
            propertiesShowProductsThatHasThisProperty.PropertyId = property.Id;
            propertiesShowProductsThatHasThisProperty.Products = products;

            return View(propertiesShowProductsThatHasThisProperty);
        }
    }
}
