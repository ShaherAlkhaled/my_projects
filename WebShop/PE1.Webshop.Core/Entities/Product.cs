using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1.Webshop.Core.Entities
{
    public class Product :BaseEntity
    {

        private string brand;
        private string name;
        private string model;
        public string Name
        {
            get { return name; }
            set { value = value.Trim().ToUpper(); name = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { value = value.Trim().ToUpper(); brand = value; }
        }



        public string Model
        {
            get { return model; }
            set { value = value.Trim().ToUpper(); model = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                price = value;
            }
        }


        public string ImageFileName { get; set; }

        public int? Rating { get; set; }

        public Category Category { get; set; }


        public ICollection<Property> Property { get; set; }
        public long CatergoryId { get; set; }

    }
}
