using Imi.Project.Api.Core.Dtos.Fishs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IFishService
    {
        Task<IEnumerable<FishResponseDto>> Get();
        Task<FishResponseDto> GetById(long id);
        Task<FishResponseDto> Add(FishRequestDto newFish);
        Task Delete(long fishId);
        Task<FishResponseDto> Update(FishRequestDto existingFish);
        Task<IEnumerable<FishResponseDto>> SearchAsync(string search);
        Task<FishResponseDto> AddOrUpdateImageAsync(long id, IFormFile file);

    }
}
