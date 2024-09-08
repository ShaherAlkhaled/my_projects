using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos.Fishs
{
    public class FishRequestDto:BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long CategoryId { get; set; }
        [Required]
        public long OriginCountryId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]

        public decimal MaxWeight { get; set; }
        [Required]

        public decimal MinWeigth { get; set; }
        [Required]
        public DateTime DateOfArrival { get; set; }
        public ICollection<long> FishProcessingIds { get; set; }

    }
}
