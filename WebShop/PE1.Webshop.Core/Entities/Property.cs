using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1.Webshop.Core.Entities
{
   public  class Property:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
