using PE1.Webshop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.ViewModels
{
    public class ProductsShowProductDetailViewModel
    {

        public long ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductPrice { get; set; }
        public string ImagePath { get; set; }
        public string ProductCategory { get; set; }
        public int? Rating { get; set; }
        public IEnumerable<Property> Properties { get; set; }
    }
}