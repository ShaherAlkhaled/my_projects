using Imi.Project.Api.Core.Dtos.Fishs;
using Imi.Project.Api.Core.Dtos.OriginCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IOriginCountryService
    {
        Task<IEnumerable<OriginCountryResponseDto>> Get();
        Task<OriginCountryResponseDto> GetById(long id);
        Task<OriginCountryResponseDto> Add(OriginCountryRequestDto newCountry);
        Task Delete(long countryId);
        Task<OriginCountryResponseDto> Update(OriginCountryRequestDto existingnCountry);
        Task<IEnumerable<FishResponseDto>> GetByOriginCountryIdAsync(long id);
    }
}
