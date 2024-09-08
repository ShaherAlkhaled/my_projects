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
    public class CategoriesController : Controller
    {
        private readonly WebShopDbContext _webShopDbContext;
        public CategoriesController(WebShopDbContext webShopDbContext)
        {
            _webShopDbContext = webShopDbContext;
        }
        public IActionResult ShowCategories()
        {
            //declare the view model
            var categoriesShowCategoriesViewModel = new CategoriesShowCategoriesViewModel();

            //fill the model
            categoriesShowCategoriesViewModel.Categories = _webShopDbContext.Categories.Select(c =>
                    new CategoriesShowDetailCategoryViewModel
                    {
                        CategoryId = c.Id,
                        CategoryName = c.Name
                    }
                );

            return View(categoriesShowCategoriesViewModel);
        }

        public IActionResult ShowDetailCategory(int id)
        {

            var categoriesShowDetailCategoryViewModel = new CategoriesShowDetailCategoryViewModel();
            var category = _webShopDbContext.Categories.FirstOrDefault(c => c.Id.Equals(id));
            categoriesShowDetailCategoryViewModel.CategoryId = category.Id;
            categoriesShowDetailCategoryViewModel.CategoryName = category?.Name;
            return View(categoriesShowDetailCategoryViewModel);
        }

        public IActionResult ShowProductsInCategory(int id)
        {
            var categoriesShowProductsInCategoryViewModel = new CategoriesShowProductsInCategoryViewModel();
            var products = _webShopDbContext
                .Products
                .Where(p => p.CatergoryId == id)
                .Select(p => new ProductsShowProductDetailViewModel
                {
                    ProductId = p.Id,
                    ProductName = $"{p.Brand} {p.Name} {p.Model}",
                    ProductPrice = p.Price.ToString("€ #0.00"),
                    ProductCategory = p.Category.Name,
                    ImagePath = p.ImageFileName,
                });
            var category = _webShopDbContext.Categories.FirstOrDefault(c => c.Id.Equals(id));

            if (category == null)
                return NotFound();
            categoriesShowProductsInCategoryViewModel.CategoryName = category.Name;
            categoriesShowProductsInCategoryViewModel.CategoryId = category.Id;
            categoriesShowProductsInCategoryViewModel.Products = products;
            return View(categoriesShowProductsInCategoryViewModel);
        }
    }
}
