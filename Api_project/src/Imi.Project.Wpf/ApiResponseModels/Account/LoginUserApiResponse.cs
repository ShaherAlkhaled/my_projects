using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels.Account
{
    public class LoginUserApiResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
