using System.Text.Json.Serialization;

namespace Imi.Project.Blazor.Models
{
    public class LoginUserApiResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
