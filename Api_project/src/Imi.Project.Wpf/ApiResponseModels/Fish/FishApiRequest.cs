using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Fish
{
    public class FishApiRequest:BaseApiResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("categoryId")]
        public long CategoryId { get; set; }
        [JsonPropertyName("originCountryId")]
        public long OriginCountryId { get; set; }

        [JsonPropertyName("urlImage")]
        public string UrlImage { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("maxWeight")]
        public decimal MaxWeight { get; set; }

        [JsonPropertyName("minWeigth")]
        public decimal MinWeigth { get; set; }

        [JsonPropertyName("dateOfArrival")]
        public DateTime DateOfArrival { get; set; }

    }
}
