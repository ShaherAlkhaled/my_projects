using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.ViewModels
{
    public class PropertiesShowProductsThatHasThisProperty
    {
        public string PropertyName { get; set; }
        public long PropertyId { get; set; }
        public IEnumerable<ProductsShowProductDetailViewModel> Products { get; set; }
    }
}
