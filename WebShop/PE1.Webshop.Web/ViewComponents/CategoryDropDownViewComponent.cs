using Microsoft.AspNetCore.Mvc;
using PE1.Webshop.Web.Data;
using PE1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.ViewComponents
{

    [ViewComponent(Name = "CategoryDropDown")]
    public class CategoryDropDownViewComponent : ViewComponent
    {
        private readonly WebShopDbContext _webShopDbContext;

        public CategoryDropDownViewComponent(WebShopDbContext webShopDbContext)
        {
            _webShopDbContext = webShopDbContext;
        }

        public IViewComponentResult Invoke()
        {
            //declare the viewmodel and add developers
            IEnumerable<CategoryDropDownViewModel>
                categoryDropDownViewModel = _webShopDbContext.Categories.Select(c =>
                    new CategoryDropDownViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    }
                );

            //pass the to the viewmodel
            return View(categoryDropDownViewModel);
        }
    }
}
