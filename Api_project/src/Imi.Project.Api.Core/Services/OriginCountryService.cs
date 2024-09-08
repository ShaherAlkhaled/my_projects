using Imi.Project.Api.Core.Dtos.Fishs;
using Imi.Project.Api.Core.Dtos.OriginCountries;
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
    public class OriginCountryService: IOriginCountryService
    {
        private readonly IOriginCountryRepository _originCountryRepository;

        public OriginCountryService(IOriginCountryRepository originCountryRepository)
        {
            _originCountryRepository = originCountryRepository;
        }

        public async Task<OriginCountryResponseDto> Add(OriginCountryRequestDto newCountry)
        {

            var countryEntity = new OriginCountry()
            {
                Name = newCountry.Name,

            };

            await _originCountryRepository.AddAsync(countryEntity);
            var saveEntity = await _originCountryRepository.GetByIdAsync(countryEntity.Id);
            return new OriginCountryResponseDto
            {
                Id = saveEntity.Id,
                Name = saveEntity.Name,
            };

        }

        public async Task Delete(long countryId)
        {
            if (await DoesCountryExists(countryId))
            {
                await _originCountryRepository.DeleteAsync(countryId);
            }
            else
            {
                throw new Exception($"Conutry with Id :{countryId} not found");
            }
        }

        public async Task<IEnumerable<OriginCountryResponseDto>> Get()
        {
            var entities = await _originCountryRepository.ListAllAsync();
            var dtos = entities.Select(e => new OriginCountryResponseDto
            {
                Id = e.Id,
                Name = e.Name,
            });
            return dtos;
        }

        public async Task<OriginCountryResponseDto> GetById(long id)
        {
            var countryEntity = await _originCountryRepository.GetByIdAsync(id);
            if (countryEntity == null)
            {
                return null;
            }
            else
            {
                var countryResponseDto = new OriginCountryResponseDto
                {
                    Id = countryEntity.Id,
                    Name = countryEntity.Name,

                };
                return countryResponseDto;
            }
        }

        public async Task<IEnumerable<FishResponseDto>> GetByOriginCountryIdAsync(long id)
        {
            if (await DoesCountryExists(id))
            {
                var fishs = await _originCountryRepository.GetByOriginCountryIdAsync(id);


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
                throw new Exception($"Country with Id :{id} not found");
            }
        }

        public async Task<OriginCountryResponseDto> Update(OriginCountryRequestDto existingnCountry)
        {
            if (await DoesCountryExists(existingnCountry.Id))
            {
                var existingCountryEntity = await _originCountryRepository.GetByIdAsync(existingnCountry.Id);

                existingCountryEntity.Name = existingnCountry.Name;

                await _originCountryRepository.UpdateAsync(existingCountryEntity);

                return new OriginCountryResponseDto
                {

                    Name = existingCountryEntity.Name,

                };

            }
            else
            {
                throw new Exception($"Country with Id :{existingnCountry.Id} not found");
            }
        }

        private async Task<bool> DoesCountryExists(long id)
        {
            var country = await _originCountryRepository.GetByIdAsync(id);
            if (country == null) return false;
            else return true;
        }


    }
}
