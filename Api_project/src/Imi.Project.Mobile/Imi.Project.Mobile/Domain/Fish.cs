using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain
{
    public class Fish
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string UrlImage { get; set; }
        public decimal MaxWeight { get; set; }

        public decimal MinWeigth { get; set; }

        public DateTime DateOfArrival { get; set; } = DateTime.Now;

        public string OriginCountryName { get; set; }
        public string CategoryName { get; set; }
        public long CategoryId { get; set; }
        public long OriginCountryId { get; set; }


    }
}
