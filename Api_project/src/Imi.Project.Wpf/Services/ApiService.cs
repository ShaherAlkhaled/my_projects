using Imi.Project.Wpf.ApiResponseModels.Account;
using Imi.Project.Wpf.ApiResponseModels.Category;
using Imi.Project.Wpf.ApiResponseModels.Fish;
using Imi.Project.Wpf.ApiResponseModels.OriginCountry;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Services
{
    public class ApiService:IApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _ApiHttpClient;


        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _ApiHttpClient = _httpClientFactory.CreateClient();
            _ApiHttpClient.BaseAddress = new Uri("https://localhost:5001/api/");

        }

        public async Task<BaseServiceResponse<List<FishApiResponse>>> GetFishes()
        {
            var response = await _ApiHttpClient.GetAsync("Fishs");
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();

                var fishesResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<List<FishApiResponse>>(responseStream);

                return new BaseServiceResponse<List<FishApiResponse>>
                {
                    IsSuccess = true,
                    Data = fishesResponse
                };
            }
            else
            {
                return new BaseServiceResponse<List<FishApiResponse>>()
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase
                };
            }

           
        }

        public async Task<BaseServiceResponse<object>> Delete(long fishId)
        {
            var deletedFish= _ApiHttpClient.DeleteAsync($"Fishs/{fishId}");
            if (deletedFish.Result.IsSuccessStatusCode)
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = true,
                   
                };
            }
            else
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = false,
                    ErrorMessage = deletedFish.Result.ReasonPhrase,
                };
            }
        }

        public async Task<BaseServiceResponse<List<CategroyApiResponse>>> GetCategories()
        {
            var response = await _ApiHttpClient.GetAsync("Categories");
            if (response.IsSuccessStatusCode)
            {
            using var responseStream = await response.Content.ReadAsStreamAsync();

            var categoriesResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<List<CategroyApiResponse>>(responseStream);

                return new BaseServiceResponse<List<CategroyApiResponse>>()
                {
                    IsSuccess = true,
                    Data = categoriesResponse
                };

            }
            else
            {
                return new BaseServiceResponse<List<CategroyApiResponse>>
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase,
                };
            }
        }
        public async Task<BaseServiceResponse<List<OriginCountryApiResponse>>> GetCountries()
        {
            var response = await _ApiHttpClient.GetAsync("OriginCountry");
            if (response.IsSuccessStatusCode)
            {
            using var responseStream = await response.Content.ReadAsStreamAsync();

            var countriesResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<List<OriginCountryApiResponse>>(responseStream);

                return new BaseServiceResponse<List<OriginCountryApiResponse>>
                {
                    IsSuccess = true,
                    Data = countriesResponse
                };
            }
            else
            {
                return new BaseServiceResponse<List<OriginCountryApiResponse>>
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase,
                };
            }
        }


        public async Task<BaseServiceResponse<object>> Create(FishApiRequest newFish)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(newFish), Encoding.UTF8, "application/json");
            var request= _ApiHttpClient.PostAsync("Fishs", httpContent);
            if (request.Result.IsSuccessStatusCode)
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = true,
                };
            }
            else
            {
                return new BaseServiceResponse<object> { IsSuccess = false, 
                    ErrorMessage=request.Result.ReasonPhrase };
            }
        }
        public async Task<BaseServiceResponse<object>> Update(FishApiRequest updatFish)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(updatFish), Encoding.UTF8, "application/json");
            var request= _ApiHttpClient.PutAsync("Fishs", httpContent);
            if (request.Result.IsSuccessStatusCode)
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = true,
                };
            }
            else
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = false,
                    ErrorMessage = request.Result.ReasonPhrase
                };
            }
        }

        public async Task<BaseServiceResponse<FishApiResponse>> GetById(long fishId)
        {
            var response = await _ApiHttpClient.GetAsync($"Fishs/{fishId}");
            using var responseStream = await response.Content.ReadAsStreamAsync();

            var fishesResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<FishApiResponse>(responseStream);

            if (response.IsSuccessStatusCode)
            {
                return new BaseServiceResponse<FishApiResponse>
                {
                    IsSuccess = true,
                    Data = fishesResponse
                };
            }
            else
            {
                return new BaseServiceResponse<FishApiResponse>
                {
                    IsSuccess = false,
                    ErrorMessage = response.ReasonPhrase
                };
            }
            
        }


        public async Task<BaseServiceResponse<object>> Register(RegisterUserApiRequest newUser)
        {

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(newUser), Encoding.UTF8, "application/json");
            var request=_ApiHttpClient.PostAsync("Accounts/register", httpContent);
            if (request.Result.IsSuccessStatusCode)
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = true,

                };
            }
            else
            {
                return new BaseServiceResponse<object>
                {
                    IsSuccess = false,
                    ErrorMessage = $"{request.Result.ReasonPhrase} : an error has occurred please check your username and email and password"
                };
            }
        }
        public async Task<BaseServiceResponse<LoginUserApiResponse>> Login(LoginUserApiRequest user)
        {
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            var response = await _ApiHttpClient.PostAsync("Accounts/login", httpContent);
            if (response.IsSuccessStatusCode)
            {
            using var responseStream = await response.Content.ReadAsStreamAsync();

            var token = await System.Text.Json.JsonSerializer.DeserializeAsync<LoginUserApiResponse>(responseStream);
            _ApiHttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.Token);
                return new BaseServiceResponse<LoginUserApiResponse>
                {
                    IsSuccess = true,
                    Data = token,
                };
            }
            else
            {
                return new BaseServiceResponse<LoginUserApiResponse>
                {
                    IsSuccess = false,
                    ErrorMessage = $"{response.ReasonPhrase} : Password or email are not correct",
                };
            }
        }

        public   Task Logout()
        {
            _ApiHttpClient.DefaultRequestHeaders.Clear();
            return Task.CompletedTask;

        }



    }
}
