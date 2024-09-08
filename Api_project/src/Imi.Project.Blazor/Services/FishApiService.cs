using BlazorInputFile;
using Imi.Project.Blazor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System;
using Imi.Project.Blazor.Services.Interfaces;

namespace Imi.Project.Blazor.Services
{
    public class FishApiService : ICrudService<FishListItem, FishItem>
    {
        private string baseUrl = "https://localhost:5001/api/Fishs";
        private string categoryUrl = "https://localhost:5001/api/Categories";
        private string countryUrl = "https://localhost:5001/api/OriginCountry";
        private string processingUrl = "https://localhost:5001/api/FishProcessing";





        private readonly HttpClient _httpClient = null;

        public FishApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<FishListItem>> GetList()
        {
            return await _httpClient
                         .GetFromJsonAsync<List<FishListItem>>
                             ($"{baseUrl}");
        }
        public async Task<FishItem> GetFishById(long id)
        {


            var response = await _httpClient
                          .GetFromJsonAsync<FishItem>
                              ($"{baseUrl}/{id}");
            var processings = await _httpClient
                         .GetFromJsonAsync<List<FishProcessing>>
                             ($"{processingUrl}");

            response.CategoriesList = await FullCategoriesInSelectListIem();
            response.CountriesList = await FullCountriesInSelectListItem();
            response.Properties = processings.Select(p => new CheckBoxModel
            {
                Id = p.Id,
                Name = p.Name,
                IsSelected = response.FishProcessings.Any(f => f.Id == p.Id),
            }).ToList();
            return response;
        }

        public async Task<FishItem> GetNew()
        {
            var fish = new FishItem();
            var categories = await FullCategoriesInSelectListIem();
            var countries = await FullCountriesInSelectListItem();
            fish.CategoriesList = categories;
            fish.CategoryId = long.Parse(categories.First().Value);
            fish.Properties = await FullProcessingInCheckBox();
            fish.CountriesList = countries;
            fish.OriginCountryId = long.Parse(countries.First().Value);
            return fish;
        }
        public async Task Create(FishItem item)
        {
            var selectedProperties = item
               .Properties
               .Where(p => p.IsSelected == true).Select(p => p.Id);
            item.FishProcessingIds = selectedProperties.ToList();
            await _httpClient.PostAsJsonAsync($"{baseUrl}", item);
        }
        public async Task Update(FishItem item)
        {
            var selectedProperties = item
                       .Properties
                       .Where(p => p.IsSelected == true).Select(p => p.Id);
            item.FishProcessingIds = selectedProperties.ToList();
            await _httpClient.PutAsJsonAsync($"{baseUrl}", item);
        }
        public async Task Delete(long id)
        {
            await _httpClient.DeleteAsync($"{baseUrl}/{id}");
        }

        public async Task FileUpload(IFileListEntry file, long id)
        {



            HttpContent fileStreamContent = new StreamContent(file.Data);
            fileStreamContent.Headers.ContentDisposition =
                new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                {
                    Name = "file",
                    FileName = file.Name
                };
            fileStreamContent.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(fileStreamContent);
                await _httpClient.PostAsync($"{baseUrl}/{id}/image", formData);

            }



        }



        public async Task<List<SelectListItem>> FullCategoriesInSelectListIem()
        {
            var categories = await _httpClient
                         .GetFromJsonAsync<List<Category>>
                             ($"{categoryUrl}");

            return categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

        }
        public async Task<List<Category>> GetCategories()
        {
            var categories = await _httpClient
                         .GetFromJsonAsync<List<Category>>
                             ($"{categoryUrl}");

            return categories;

        }

        public async Task<List<SelectListItem>> FullCountriesInSelectListItem()
        {
            var countries = await _httpClient
                         .GetFromJsonAsync<List<OriginCountry>>
                             ($"{countryUrl}");
            return countries.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
        }
        public async Task<List<OriginCountry>> GetCountries()
        {
            var countries = await _httpClient
                         .GetFromJsonAsync<List<OriginCountry>>
                             ($"{countryUrl}");
            return countries;
        }

        public async Task<List<FishProcessing>> GetProcessing()
        {
            var processings = await _httpClient
                         .GetFromJsonAsync<List<FishProcessing>>
                             ($"{processingUrl}");
            return processings;
        }
        public async Task<List<CheckBoxModel>> FullProcessingInCheckBox()
        {
            var processings = await _httpClient
                         .GetFromJsonAsync<List<FishProcessing>>
                             ($"{processingUrl}");
            return processings.Select(p => new CheckBoxModel
            {
                Id = p.Id,
                Name = p.Name,
                IsSelected = false,
            }).ToList();
        }

    }
}
