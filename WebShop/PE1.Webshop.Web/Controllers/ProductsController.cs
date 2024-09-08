using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PE1.Webshop.Core.Entities;
using PE1.Webshop.Web.Data;
using PE1.Webshop.Web.Models;
using PE1.Webshop.Web.Services.Interfaces;
using PE1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly WebShopDbContext _webShopDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFileService _fileService;
        public ProductsController(WebShopDbContext webShopDbContext, IWebHostEnvironment webHostEnvironment, IFileService fileService)
        {
            _webShopDbContext = webShopDbContext;
            _webHostEnvironment = webHostEnvironment;
            _fileService = fileService;
        }

        public async Task<IActionResult> ShowProducts()
        {
            var viewModel = new ProductsShowProductsViewModel();

            viewModel.Products = await _webShopDbContext
                 .Products
                 .Select(p => new ProductsShowProductDetailViewModel
                 {
                     ProductId = p.Id,
                     ProductName = $"{p.Brand} {p.Name} {p.Model}",
                     ProductPrice = p.Price.ToString("€ #0.00"),
                     ProductCategory = p.Category.Name,
                     ImagePath = p.ImageFileName,
                 }).ToListAsync();
            return View(viewModel);
        }

        public async Task<IActionResult> ShowProductDetail(int productId)
        {

            var viewModel = new ProductsShowProductDetailViewModel();


            var product = await _webShopDbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Property)
                .FirstOrDefaultAsync(p => p.Id.Equals(productId));

            if (product == null)
                return NotFound();
            viewModel.ProductName = $"{product?.Brand ?? "No Brand"} {product?.Name ?? "No Name"} {product?.Model ?? "No Model"}";
            viewModel.ProductCategory = product?.Category?.Name ?? "No Caegory Name";
            viewModel.ProductPrice = product?.Price.ToString("€ #0.00") ?? "€ 00";
            viewModel.ImagePath = product?.ImageFileName ?? $"placeholder.jpg";
            viewModel.Properties = product?.Property;
            viewModel.Rating = product?.Rating ?? 0;
            //give it to the view
            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProductsCreateUpdateViewModel productsCreateViewModel = new();
            productsCreateViewModel.Properties = await _webShopDbContext.Properties
            .Select(p => new CheckboxModel
            {
                Name = p.Name,
                Id = p.Id,
                IsSelected = false
            }

            ).ToListAsync();



            productsCreateViewModel.Items = await _webShopDbContext
                .Categories
                .Select(c => new SelectListItem
                {

                    Text = c.Name.ToString(),
                    Value = c.Id.ToString(),
                    Selected = false

                }).ToListAsync();
            productsCreateViewModel.Items.Insert(0, new SelectListItem { Value = "0", Text = "---Please Select the Category form select list----" });
            //send to the view
            return View(productsCreateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ProductsCreateUpdateViewModel productsCreateViewModel)
        {
            if (productsCreateViewModel.SelectedItem == 0)
            {

                ModelState.AddModelError("SelectedItem", "Please select ");
            }
            if (!ModelState.IsValid)
            {



                productsCreateViewModel.Items = await _webShopDbContext
                              .Categories
                              .Select(c => new SelectListItem
                              {

                                  Text = c.Name.ToString(),
                                  Value = c.Id.ToString(),


                              }).ToListAsync();
                productsCreateViewModel.Items.Insert(0, new SelectListItem { Value = "0", Text = "---Please Select the Category form select list----" });

                return View(productsCreateViewModel);
            }

            Product newProduct = new Product();

            newProduct.Name = productsCreateViewModel.Name;
            newProduct.Brand = productsCreateViewModel.Brand;
            newProduct.Model = productsCreateViewModel.Model;
            newProduct.Price = productsCreateViewModel.Price;
            newProduct.Rating = productsCreateViewModel.Rating;
            newProduct.CatergoryId = productsCreateViewModel.SelectedItem;

            if (productsCreateViewModel.Image != null)
            {
                //    //check file extension
                //if (!Path.GetExtension(productsCreateViewModel.Image.FileName).Equals(".jpg") )
                //{
                //productsCreateViewModel.Items = await _webShopDbContext
                //  .Categories
                //  .Select(c => new SelectListItem
                //  {

                //      Text = c.Name.ToString(),
                //      Value = c.Id.ToString(),


                //  }).ToListAsync();
                //productsCreateViewModel.Items.Insert(0, new SelectListItem { Value = "0", Text = "---Please Select the Category form select list----" });

                //productsCreateViewModel.Properties =
                //await _webShopDbContext.Properties
                //.Select(p => new CheckboxModel
                //{
                //    Name = p.Name,
                //    Id = p.Id,

                //}).ToListAsync();


                //    ModelState.AddModelError("", "Only jpg allowed!");
                //    return View(productsCreateViewModel);
                //}


                ////create image path
                //string fileName = $"{Guid.NewGuid()}_{productsCreateViewModel.Image.FileName}";
                //string filePath = Path
                //    .Combine(_webHostEnvironment.WebRootPath, "images", fileName);
                //newProduct.ImageFileName = fileName;
                ////store image
                //using (FileStream fileStream = new(filePath, FileMode.Create))
                //{
                //    await productsCreateViewModel.Image.CopyToAsync(fileStream);
                //}
                newProduct.ImageFileName = await _fileService.StoreFile(productsCreateViewModel.Image);

            }


            var selectedProperties = productsCreateViewModel
                .Properties
                .Where(p => p.IsSelected == true).Select(p => p.Id);
            newProduct.Property = await _webShopDbContext
                .Properties
                .Where(p => selectedProperties.Contains(p.Id)).ToListAsync();

            _webShopDbContext.Products.Add(newProduct);
            await _webShopDbContext.SaveChangesAsync();


            return RedirectToAction("ShowProducts", "Products");
        }



        [HttpGet]
        public async Task<IActionResult> Edit(long id)
        {


            ProductsCreateUpdateViewModel productsUpdateViewModel
                = new();

            var product = await _webShopDbContext
                .Products
                .Include(p => p.Property)
                .FirstOrDefaultAsync(p => p.Id == id);

            productsUpdateViewModel.Id = product?.Id ?? 0;
            productsUpdateViewModel.Name = product?.Name ?? "No Name";
            productsUpdateViewModel.Brand = product?.Brand ?? "No Brand";
            productsUpdateViewModel.Model = product?.Model ?? "No Model";
            productsUpdateViewModel.Price = product?.Price ?? 0;
            productsUpdateViewModel.Rating = product?.Rating ?? 0;
            productsUpdateViewModel.SelectedItem = product.CatergoryId;


            productsUpdateViewModel.Properties =
                await _webShopDbContext
                 .Properties
                .Select(p => new CheckboxModel
                {
                    Name = p.Name,
                    Id = p.Id,
                    IsSelected = _webShopDbContext.Products.Include(p => p.Property).FirstOrDefault(pr => pr.Id == product.Id).Property.Any(pp => pp.Id == p.Id)
                }).ToListAsync();

            foreach (var propertidCheckbox in productsUpdateViewModel.Properties)
            {
                if (product.Property.Any(p => p.Id == propertidCheckbox.Id))
                {
                    propertidCheckbox.IsSelected = true;
                }
            }

            productsUpdateViewModel.Items =
                await _webShopDbContext
                .Categories
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                }).ToListAsync();
            productsUpdateViewModel.Items.Insert(0, new SelectListItem { Value = "0", Text = "---Please Select the Category form select list----" });

            return View(productsUpdateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(ProductsCreateUpdateViewModel productsUpdatViewModel)
        {

            //if (productsUpdatViewModel.Image != null &&
            //    !Path.GetExtension(productsUpdatViewModel.Image?.FileName).Equals(".jpg"))
            //{
            //    ModelState.AddModelError("", "image must be .jpg!");
            //}


            if (productsUpdatViewModel.SelectedItem == 0)
            {
                //add a custom errormessage to ModelState
                ModelState.AddModelError("SelectedItem", "Please select ");
            }
            if (!ModelState.IsValid)
            {


                productsUpdatViewModel.Items = await _webShopDbContext
                              .Categories
                              .Select(c => new SelectListItem
                              {

                                  Text = c.Name.ToString(),
                                  Value = c.Id.ToString(),


                              }).ToListAsync();
                productsUpdatViewModel.Items.Insert(0, new SelectListItem { Value = "0", Text = "---Please Select the Category form select list----" });


                return View(productsUpdatViewModel);
            }

            var product = await
                _webShopDbContext.Products
                .Include(p => p.Property)
                .FirstOrDefaultAsync(p => p.Id == productsUpdatViewModel.Id);



            product.Name = productsUpdatViewModel.Name;
            product.Brand = productsUpdatViewModel.Brand;
            product.Model = productsUpdatViewModel.Model;
            product.Price = productsUpdatViewModel.Price;
            product.Rating = productsUpdatViewModel.Rating;
            product.CatergoryId = productsUpdatViewModel.SelectedItem;
            var selectedProperties = productsUpdatViewModel
                .Properties
                .Where(p => p.IsSelected == true).Select(p => p.Id);
            product.Property = await _webShopDbContext
                .Properties
                .Where(p => selectedProperties.Contains(p.Id)).ToListAsync();


            //  //update image if not null
            if (productsUpdatViewModel.Image != null)
            {
                //check if existing movie had an image in the first place
                if (product.ImageFileName == null)
                {
                    //create unique filename
                    //product.ImageFileName = $"{Guid.NewGuid()}_{productsUpdatViewModel.Image.FileName}";
                    product.ImageFileName = await _fileService.StoreFile(productsUpdatViewModel.Image);
                }

                //var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", product.ImageFileName);
                //using (FileStream fileStream = new(filePath, FileMode.Create))
                //{
                //    await productsUpdatViewModel.Image.CopyToAsync(fileStream);
                //}
                product.ImageFileName = await _fileService.StoreFile(productsUpdatViewModel.Image);

            }
            //save
            await _webShopDbContext.SaveChangesAsync();
            return RedirectToAction("ShowProducts", "Products");

        }


        [HttpGet]
        public IActionResult ConfirmDelete(long id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(long id)
        {

            var product = await _webShopDbContext
                .Products
                .FirstOrDefaultAsync(p => p.Id == id);
            _webShopDbContext.Products.Remove(product);
            await _webShopDbContext.SaveChangesAsync();
            return RedirectToAction("ShowProducts", "Products");

        }


    }
}
