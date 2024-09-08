using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE1.Webshop.Web.Data;
using PE1.Webshop.Web.Models;
using PE1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly WebShopDbContext _webShopDbContext;

        private readonly SearchViewModel _searchViewModel;

        public SearchController(WebShopDbContext webShopDbContext)
        {

            _webShopDbContext = webShopDbContext;
            _searchViewModel = new SearchViewModel();
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShowProductsByPriceAndCategroy(decimal price, string categoryName)
        {

            var products = await _webShopDbContext
                .Products
                .Include(p => p.Category)
                .Include(p => p.Property)
                .Where((p => p.Price > price && p.Category.Name == categoryName)).ToListAsync();
            var helpShowProductsService = new HelpShowProductsService();

            _searchViewModel.SortedProducts = helpShowProductsService.ShowProducts(products);

            return View(_searchViewModel);
        }
        public async Task<IActionResult> ShowProductsByCategoryAndProperty(string property, string categoryName)
        {

            var products = await _webShopDbContext
                .Products
                .Include(p => p.Category)
                .Include(p => p.Property)
                .Where(p => p.Category.Name == categoryName && p.Property.Any(pr => pr.Name == property)).ToListAsync();
            var helpShowProductsService = new HelpShowProductsService();

            _searchViewModel.SortedProducts = helpShowProductsService.ShowProducts(products);
            return View(_searchViewModel);
        }

        public async Task<IActionResult> ShowProductsByCategoryAndBrand(string brand, string categoryName)
        {

            var products = await _webShopDbContext
                .Products
                .Include(p => p.Category)
                .Include(p => p.Property)
                .Where(p => p.Category.Name == categoryName && p.Brand == brand).ToListAsync();

            var helpShowProductsService = new HelpShowProductsService();

            _searchViewModel.SortedProducts = helpShowProductsService.ShowProducts(products);
            return View(_searchViewModel);
        }
    }
}
