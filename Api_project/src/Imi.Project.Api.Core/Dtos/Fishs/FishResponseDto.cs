using Imi.Project.Api.Core.Dtos.FishProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos.Fishs
{
    public class FishResponseDto:BaseDto
    {
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public long CategoryId { get; set; }
        public string OriginCountryName { get; set; }
        public long OriginCountryId { get; set; }
        public string UrlImage { get; set; }

        public decimal Price { get; set; }
        public decimal MaxWeight { get; set; }

        public decimal MinWeigth { get; set; }
        public DateTime DateOfArrival { get; set; }
        public ICollection<FishProcessingResponseDto> FishProcessings { get; set; }
    }
}
