using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1.Webshop.Core.Entities
{
   public  class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
