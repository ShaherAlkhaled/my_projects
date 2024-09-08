using Imi.Project.Api.Core.Dtos.FishProcessing;
using Imi.Project.Api.Core.Dtos.Fishs;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class FishService : IFishService
    {

        private readonly IFishRepository _fishRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOriginCountryRepository _originCountryRepository;
        private readonly IFishProcessingRepository _fishProcessingRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostEnvironment _webHostEnvironment;



        public FishService(IFishRepository fishReopistory,
            ICategoryRepository categoryRepository,
            IOriginCountryRepository originCountryRepository,
            IFishProcessingRepository fishProcessingRepository,
            IHttpContextAccessor httpContextAccessor, IHostEnvironment webHostEnvironment)
        {
            _fishRepository = fishReopistory;
            _categoryRepository = categoryRepository;
            _originCountryRepository = originCountryRepository;
            _fishProcessingRepository = fishProcessingRepository;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }


        //}


        public async Task<FishResponseDto> Add(FishRequestDto newFish)
        {

            var processings = new List<FishProcessing>();
            if (newFish.FishProcessingIds != null)
            {
            
                foreach (var id in newFish.FishProcessingIds)
                {
                    var processing = await _fishProcessingRepository.GetByIdAsync(id);
                    if (processing != null)
                    {
                        processings.Add(processing);
                    }

                }
            }

            var fishEntity = new Fish()
            {
                Name = newFish.Name,
                CategoryId = newFish.CategoryId,
                OriginCountryId = newFish.OriginCountryId,
                Price = newFish.Price,
                MaxWeight = newFish.MaxWeight,
                MinWeigth = newFish.MinWeigth,
                DateOfArrival = newFish.DateOfArrival,
                FishProssings = processings
            };


            if (await _categoryRepository.GetByIdAsync(newFish.CategoryId) == null)
            {
                throw new Exception($"Category with id : {newFish.CategoryId} not found");

            }
            else if (await _originCountryRepository.GetByIdAsync(newFish.OriginCountryId) == null)
            {
                throw new Exception($"Country with id : {newFish.OriginCountryId} not found");
            }
            else
            {
                await _fishRepository.AddAsync(fishEntity);
                var saveEntity = await _fishRepository.GetByIdAsync(fishEntity.Id);
                return new FishResponseDto
                {

                    Id = saveEntity.Id,
                    Name = saveEntity.Name,
                    CategoryId = saveEntity.CategoryId,
                    OriginCountryId = saveEntity.OriginCountryId,
                    CategoryName = saveEntity.Category.Name,
                    OriginCountryName = saveEntity.OriginCountry.Name,
                    UrlImage = CreateAbsolutePath(saveEntity?.UrlImage ?? "images/default.jpg"),
                    Price = saveEntity.Price,
                    MinWeigth = saveEntity.MinWeigth,
                    MaxWeight = saveEntity.MaxWeight,
                    DateOfArrival = saveEntity.DateOfArrival,
                    FishProcessings = saveEntity.FishProssings.Select(p => new FishProcessingResponseDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                    }).ToList()


                };
            }

        }

        public async Task Delete(long fishId)
        {
            if (await DoesFishExists(fishId))
            {
                await _fishRepository.DeleteAsync(fishId);
            }
            else
            {
                throw new Exception("Fish doesn't exist!");
            }
        }

        public async Task<IEnumerable<FishResponseDto>> Get()
        {

            var entities = await _fishRepository.ListAllAsync();
            var dtos = entities.Select(e => new FishResponseDto
            {
                Id = e.Id,
                Name = e.Name,
                CategoryId = e.CategoryId,
                OriginCountryId = e.OriginCountryId,
                OriginCountryName = e.OriginCountry.Name,
                CategoryName = e.Category.Name,
                UrlImage = CreateAbsolutePath(e?.UrlImage ?? "images/default.jpg"),
                Price = e.Price,
                MinWeigth = e.MinWeigth,
                MaxWeight = e.MaxWeight,
                DateOfArrival = e.DateOfArrival,
                FishProcessings = e.FishProssings.Select(f => new FishProcessingResponseDto
                {
                    Id = f.Id,
                    Name = f.Name,
                }).ToList(),
            });
            return dtos;
        }

        public async Task<FishResponseDto> GetById(long id)
        {
            var fishEntity = await _fishRepository.GetByIdAsync(id);
            if (fishEntity == null)
            {
                return null;
            }
            else
            {
                var fishResponseDto = new FishResponseDto
                {
                    Id = fishEntity.Id,
                    Name = fishEntity.Name,
                    CategoryId = fishEntity.CategoryId,
                    OriginCountryId = fishEntity.OriginCountryId,
                    OriginCountryName = fishEntity.OriginCountry.Name,
                    CategoryName = fishEntity.Category.Name,
                    UrlImage = CreateAbsolutePath(fishEntity?.UrlImage ?? "images/default.jpg"),
                    Price = fishEntity.Price,
                    MaxWeight = fishEntity.MaxWeight,
                    MinWeigth = fishEntity.MinWeigth,
                    DateOfArrival = fishEntity.DateOfArrival,
                    FishProcessings = fishEntity.FishProssings.Select(p => new FishProcessingResponseDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                    }).ToList()

                };
                return fishResponseDto;
            }


        }

        public async Task<IEnumerable<FishResponseDto>> SearchAsync(string search)
        {

            var fishs = await _fishRepository.SearchAsync(search);


            return fishs.Select(f => new FishResponseDto
            {
                Id = f.Id,
                Name = f.Name,
                OriginCountryId = f.OriginCountryId,
                CategoryId = f.CategoryId,
                CategoryName = f.Category.Name,
                OriginCountryName = f.OriginCountry.Name,
                UrlImage = CreateAbsolutePath(f?.UrlImage ?? "images/default.jpg"),
                Price = f.Price,
                MinWeigth = f.MinWeigth,
                MaxWeight = f.MaxWeight,
                DateOfArrival = f.DateOfArrival,
                FishProcessings = f.FishProssings.Select(p => new FishProcessingResponseDto
                {
                    Id = p.Id,
                    Name = p.Name,
                }).ToList()

            });

        }

        public async Task<FishResponseDto> Update(FishRequestDto existingFish)
        {


            if (await DoesFishExists(existingFish.Id))
            {
                var existingFishEntity = await _fishRepository.GetByIdAsync(existingFish.Id);
                var processings = new List<FishProcessing>();
                if (existingFish.FishProcessingIds != null)
                {
                    existingFishEntity.FishProssings.Clear();
                    foreach (var id in existingFish.FishProcessingIds)
                    {
                        var processing = await _fishProcessingRepository.GetByIdAsync(id);
                        if (processing != null)
                        {
                            processings.Add(processing);
                        }
                    }
                }
                if (await _categoryRepository.GetByIdAsync(existingFish.CategoryId) == null)
                {
                    throw new Exception($"Category with id : {existingFish.CategoryId} not found");

                }
                else if (await _originCountryRepository.GetByIdAsync(existingFish.OriginCountryId) == null)
                {
                    throw new Exception($"Country with id : {existingFish.OriginCountryId} not found");
                }
                else
                {
                    existingFishEntity.Id = existingFish.Id;
                    existingFishEntity.Name = existingFish.Name;
                    existingFishEntity.CategoryId = existingFish.CategoryId;
                    existingFishEntity.OriginCountryId = existingFish.OriginCountryId;
                    existingFishEntity.Price = existingFish.Price;
                    existingFishEntity.MinWeigth = existingFish.MinWeigth;
                    existingFishEntity.MaxWeight = existingFish.MaxWeight;
                    existingFishEntity.DateOfArrival = existingFish.DateOfArrival;
                    existingFishEntity.FishProssings = processings;



                    await _fishRepository.UpdateAsync(existingFishEntity);
                    existingFishEntity = await _fishRepository.GetByIdAsync(existingFish.Id);
                    var fishResponseDto = new FishResponseDto
                    {
                        Id = existingFishEntity.Id,
                        Name = existingFishEntity.Name,
                        CategoryId = existingFishEntity.CategoryId,
                        OriginCountryId = existingFishEntity.OriginCountryId,
                        OriginCountryName = existingFishEntity.OriginCountry.Name,
                        CategoryName = existingFishEntity.Category.Name,
                        UrlImage = CreateAbsolutePath(existingFishEntity?.UrlImage ?? "images/default.jpg"),
                        Price = existingFishEntity.Price,
                        MinWeigth = existingFishEntity.MinWeigth,
                        MaxWeight = existingFishEntity.MaxWeight,
                        DateOfArrival = existingFishEntity.DateOfArrival,
                        FishProcessings = existingFishEntity.FishProssings.Select(p => new FishProcessingResponseDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                        }).ToList()
                    };

                    return fishResponseDto;

                }
            }
            else
            {
                throw new Exception($"Fish with {existingFish.Id}  not found!");
            }

        }



        public async Task<FishResponseDto> AddOrUpdateImageAsync(long id, IFormFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException("Please entr image");
            }
            var fileType = Path.GetExtension(file.FileName);

            if (fileType.Equals(".jpg") || fileType.Equals(".png"))
            {
                if (await DoesFishExists(id))
                {
                    var fishEntry = await _fishRepository.GetByIdAsync(id);
                    SaveImageOnDisk(file);
                    fishEntry.UrlImage = $"images/{file.FileName}";
                    await _fishRepository.UpdateAsync(fishEntry);

                    return new FishResponseDto
                    {
                        Id = fishEntry.Id,
                        Name = fishEntry.Name,
                        CategoryId = fishEntry.CategoryId,
                        OriginCountryId = fishEntry.OriginCountryId,
                        OriginCountryName = fishEntry.OriginCountry.Name,
                        CategoryName = fishEntry.Category.Name,
                        UrlImage = CreateAbsolutePath(fishEntry?.UrlImage ?? "images/default.jpg"),
                        Price = fishEntry.Price,
                        MaxWeight = fishEntry.MaxWeight,
                        MinWeigth = fishEntry.MinWeigth,
                        DateOfArrival = fishEntry.DateOfArrival,
                        FishProcessings = fishEntry.FishProssings.Select(p => new FishProcessingResponseDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                        }).ToList()

                    };
                }
                else
                {
                    throw new Exception($"Fish with {id}  not found!");
                }

            }
            else
            {
                throw new Exception("Only jpg or png allowed!");
            }

        }
        private async void SaveImageOnDisk(IFormFile file)
        {
            var fileType = Path.GetExtension(file.FileName);
            var filePath = _webHostEnvironment.ContentRootPath;
            var fileName = Path.GetFileName(file.FileName);
            var totalPath = Path.Combine(_webHostEnvironment.ContentRootPath,
             "wwwroot", "images", fileName);

            if (File.Exists(totalPath))
            {
                File.Delete(totalPath);
            }
            using (var stream = new FileStream(totalPath, FileMode.Create))
            {
               await file.CopyToAsync(stream);
            }

        }


        private string CreateAbsolutePath(string imagePath)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var scheme = request.Scheme;
            var rootUrl = request.Host;
            return $"{scheme}://{rootUrl}/{imagePath}";
        }
        private async Task<bool> DoesFishExists(long id)
        {
            var fish = await _fishRepository.GetByIdAsync(id);
            if (fish == null) return false;
            else return true;
        }

    }
}
