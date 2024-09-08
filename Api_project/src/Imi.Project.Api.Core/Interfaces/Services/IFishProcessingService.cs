using Imi.Project.Api.Core.Dtos.FishProcessing;
using Imi.Project.Api.Core.Dtos.Fishs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IFishProcessingService
    {
        Task<IEnumerable<FishProcessingResponseDto>> Get();
        Task<FishProcessingResponseDto> GetById(long id);
        Task<FishProcessingResponseDto> Add(FishProcessingRequestDto newFishProcessing);
        Task Delete(long processingId);
        Task<FishProcessingResponseDto> Update(FishProcessingRequestDto existingProcessing);
        Task<IEnumerable<FishResponseDto>> GetByProcessingIdAsync(long id);
    }
}
