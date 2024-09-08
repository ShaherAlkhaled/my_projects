using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.ViewModels
{
    public class CategoriesShowProductsInCategoryViewModel
    {
        public string CategoryName { get; set; }
        public long CategoryId { get; set; }

        public IEnumerable<ProductsShowProductDetailViewModel> Products { get; set; }

    }
}
