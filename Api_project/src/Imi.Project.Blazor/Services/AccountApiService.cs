using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class AccountApiService : IAccountService
    {
        private string loginUrl = "https://localhost:5001/api/Accounts/login";
        private string registerUrl = "https://localhost:5001/api/Accounts/register";
        

        private readonly HttpClient _httpClient = null;

        public AccountApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<LoginUserApiResponse> Login(UserAppilcation user)
        {
            _httpClient.DefaultRequestHeaders.Clear();

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");


            var response = await _httpClient.PostAsync($"{loginUrl}", httpContent);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();

                var token = await System.Text.Json.JsonSerializer.DeserializeAsync<LoginUserApiResponse>(responseStream);
                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.Token);
                return token;

            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }

        }

        public Task Register(RegisterAppilcation newUser)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");
            var request = _httpClient.PostAsync($"{registerUrl}", httpContent);
            if (request.Result.IsSuccessStatusCode)
            {
                return Task.CompletedTask;
            }
            else
            {
                throw new Exception($"{request.Result.ReasonPhrase} : an error has occurred please check your username and email and password");
            }

        }
        public bool CheckLogIn()
        {
            try
            {

            return _httpClient.DefaultRequestHeaders.GetValues("Authorization") != null;
            }
            catch
            {
                throw new Exception("U Bent nog niet ingelogd");
            }
        }
        public async Task Logout()
        {
            _httpClient.DefaultRequestHeaders.Clear();
        }
    }
}
