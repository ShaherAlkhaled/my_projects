using PE1.Webshop.Core.Entities;
using PE1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Models
{
    public class HelpShowProductsService
    {
        public IEnumerable<ProductsShowProductDetailViewModel> ShowProducts(IEnumerable<Product> products)
        {
            var productViewModels = new List<ProductsShowProductDetailViewModel>();
            foreach (var product in products)
            {

                productViewModels.Add(
                    new ProductsShowProductDetailViewModel
                    {
                        ProductId = product?.Id ?? 0,
                        ProductName = $"{product?.Brand} {product?.Name} {product?.Model}" ?? "No Name",
                        ProductPrice = product?.Price.ToString("€ #0.00") ?? "No Price",
                        ImagePath = product?.ImageFileName ?? "No Image",
                        ProductCategory = product?.Category.Name
                    });
            }
            return productViewModels;
        }
    }
}
