using Imi.Project.Mobile.Constants;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Infrastructure
{
    public class OriginCountryService:IOriginCountryService
    {
        private readonly string _baseUri;

        public OriginCountryService()
        {
            _baseUri = Url.BaseUri;
        }

        public async Task<IQueryable<OriginCountry>> Get()
        {
            var countries = await WebApiClient
                                   .GetApiResult<List<OriginCountry>>($"{_baseUri}OriginCountry");
            return countries.AsQueryable();

        }
        public async Task<OriginCountry> GetById(long id)
        {
            var country = await WebApiClient.GetApiResult<OriginCountry>($"{_baseUri}OriginCountry/{id}");
            return await Task.FromResult(country);
        }

        public async Task<IQueryable<Fish>> GetFishesByCountryIdAsync(long id)
        {
            var fishesByCountry = await WebApiClient
                                                 .GetApiResult<IEnumerable<Fish>>($"{_baseUri}OriginCountry/{id}/Fishs");

            return fishesByCountry.AsQueryable();
        }
    }
}
