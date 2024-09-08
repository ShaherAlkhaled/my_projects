using Imi.Project.Mobile.Constants;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Infrastructure
{
    public class FishService:IFishService
    {
        private readonly string _baseUri;

        public FishService()
        {
            _baseUri = Url.BaseUri;
        }


        private static HttpClientHandler ClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();
#if DEBUG
            //allow connecting to untrusted certificates when running a DEBUG assembly
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
#endif
            return httpClientHandler;
        }

        public async Task<List<Fish>> Get()
        {
            var fishes = await WebApiClient
                                      .GetApiResult<List<Fish>>($"{_baseUri}Fishs");
            return fishes;
        }

        public async Task<Fish> GetById(long id)
        {
            var fish = await WebApiClient.GetApiResult<Fish>($"{_baseUri}Fishs/{id}");
            return await Task.FromResult(fish);
        }
        public async Task<Fish> Add(Fish newFish)
        {
            var fish = await WebApiClient
                           .PostCallApi<Fish, Fish>($"{_baseUri}Fishs", newFish);
            return fish;
        }

        public async Task<Fish> Update(Fish existingFish)
        {

            return await WebApiClient
                            .PutCallApi<Fish, Fish>($"{_baseUri}Fishs", existingFish);
        }
        public async Task Delete(long fishId)
        {
           await WebApiClient.DeleteCallApi<Fish>($"{ _baseUri}Fishs/{fishId}");
        }


      


  

        public Task<IQueryable<Fish>> SearchAsync(string search)
        {
            throw new NotImplementedException();
        }
        public async Task UploadImage(long id, Stream fileStream, string fileName)
        {
            using (var client = new HttpClient(ClientHandler()))
            {
                var token = await SecureStorage.GetAsync("token");
                if (token != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                }
                HttpContent fileStreamContent = new StreamContent(fileStream);
                fileStreamContent.Headers.ContentDisposition =
                    new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                    {
                        Name = "file",
                        FileName = fileName
                    };
                fileStreamContent.Headers.ContentType =
                    new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                using (var formData = new MultipartFormDataContent())
                {
                    formData.Add(fileStreamContent);
                    await client.PostAsync($"{_baseUri}Fishs/{id}/image", formData);

                }
            }
        }


    }
}
