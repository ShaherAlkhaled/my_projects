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
    public class FishProcessingService : IFishProcessingService
    {
        private readonly string _baseUri;

        public FishProcessingService()
        {
            _baseUri = Url.BaseUri;
        }


        public async Task<IQueryable<FishProcessing>> Get()
        {
            var processings = await WebApiClient
                                               .GetApiResult<List<FishProcessing>>($"{_baseUri}FishProcessing");
            return processings.AsQueryable();      
        }
    }
}
