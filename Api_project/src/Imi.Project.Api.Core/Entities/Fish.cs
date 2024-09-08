using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Entities
{
    public class Fish:BaseEntity
    {
        [Required]
        [StringLength(150, ErrorMessage = "Name can not be too long")]

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string UrlImage { get; set; }
        public decimal MaxWeight { get; set; }

        public decimal MinWeigth { get; set; }

        public DateTime DateOfArrival { get; set; } = DateTime.Now;

        public long OriginCountryId { get; set; }
        public OriginCountry OriginCountry { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<FishProcessing> FishProssings { get; set; }
    }
}
