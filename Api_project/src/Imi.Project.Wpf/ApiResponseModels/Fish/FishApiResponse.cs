using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Fish
{
    public class FishApiResponse:BaseApiResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; }
        [JsonPropertyName("originCountryName")]
        public string OriginCountryName { get; set; }

        [JsonPropertyName("categoryId")]
        public long CategoryId { get; set; }
        [JsonPropertyName("originCountryId")]
        public long OriginCountryId { get; set; }

        [JsonPropertyName("urlImage")]
        public string ImagePath { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("maxWeight")]
        public string MaxWeight { get; set; }

        [JsonPropertyName("minWeigth")]
        public string MinWeigth { get; set; }

        [JsonPropertyName("dateOfArrival")]
        public string DateOfArrival { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
