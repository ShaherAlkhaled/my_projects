using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.ViewModels
{
    public class SearchViewModel   // i need only this view model because the reslut of all actions in search controller is List of ProductsShowProductDetailViewModel
    {
        public IEnumerable<ProductsShowProductDetailViewModel> SortedProducts { get; set; }

    }
}
