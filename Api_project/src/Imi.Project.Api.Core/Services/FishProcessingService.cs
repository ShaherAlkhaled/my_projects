using Imi.Project.Api.Core.Dtos.FishProcessing;
using Imi.Project.Api.Core.Dtos.Fishs;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class FishProcessingService:IFishProcessingService
    {
        private readonly IFishProcessingRepository _processingRepository;

        public FishProcessingService(IFishProcessingRepository processingRepository)
        {
            _processingRepository = processingRepository;
        }

        public async Task<FishProcessingResponseDto> Add(FishProcessingRequestDto newFishProcessing)
        {
            var fishProcessingEntity = new FishProcessing()
            {
                Name = newFishProcessing.Name,

            };
            await _processingRepository.AddAsync(fishProcessingEntity);
            var saveEntity = await _processingRepository.GetByIdAsync(fishProcessingEntity.Id);
            return new FishProcessingResponseDto
            {
                Id = saveEntity.Id,
                Name = saveEntity.Name,
            };

        }

        public async Task Delete(long processingId)
        {
            if (await DoesProcessingExists(processingId))
            {
                await _processingRepository.DeleteAsync(processingId);
            }
            else
            {
                throw new Exception($"FishProcessing with Id :{processingId} not found");
            }
        }

        public async Task<IEnumerable<FishProcessingResponseDto>> Get()
        {
            var entities = await _processingRepository.ListAllAsync();
            var dtos = entities.Select(e => new FishProcessingResponseDto
            {
                Id = e.Id,
                Name = e.Name,
            });
            return dtos;
        }

        public async Task<FishProcessingResponseDto> GetById(long id)
        {
            var categoryEntity = await _processingRepository.GetByIdAsync(id);
            if (categoryEntity == null)
            {
                return null;
            }
            else
            {
                var fishProcessingResponseDto = new FishProcessingResponseDto
                {
                    Id = categoryEntity.Id,
                    Name = categoryEntity.Name,

                };
                return fishProcessingResponseDto;
            }
        }

        public async Task<IEnumerable<FishResponseDto>> GetByProcessingIdAsync(long id)
        {
            if (await DoesProcessingExists(id))
            {
                var fishs = await _processingRepository.GetByProcessingIdAsync(id);


                return fishs.Select(f => new FishResponseDto
                {
                    Id = f.Id,
                    Name = f.Name,
                    OriginCountryId = f.OriginCountryId,
                    CategoryId = f.CategoryId,
                    CategoryName = f.Category.Name,
                    OriginCountryName = f.OriginCountry.Name,
                });
            }
            else
            {
                throw new Exception($"FishProcessing with Id :{id} not found");
            }
        }

        public async Task<FishProcessingResponseDto> Update(FishProcessingRequestDto existingProcessing)
        {
            if (await DoesProcessingExists(existingProcessing.Id))
            {
                var existingProcessingEntity = await _processingRepository.GetByIdAsync(existingProcessing.Id);

                existingProcessingEntity.Name = existingProcessing.Name;

                await _processingRepository.UpdateAsync(existingProcessingEntity);

                return new FishProcessingResponseDto
                {

                    Name = existingProcessingEntity.Name,

                };

            }
            else
            {
                throw new Exception($"FishProcessing with Id :{existingProcessing.Id} not found");
            }
        }

        private async Task<bool> DoesProcessingExists(long id)
        {
            var fishProcessing = await _processingRepository.GetByIdAsync(id);
            if (fishProcessing == null) return false;
            else return true;
        }

    }
}
