using Imi.Project.Api.Core.Dtos.Categories;
using Imi.Project.Api.Core.Dtos.Fishs;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class CategoryService:ICategoryService
    {

        private readonly ICategoryRepository _categories;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public CategoryService(ICategoryRepository categories, IHttpContextAccessor httpContextAccessor)
        {
            _categories = categories;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<CategoryResponseDto> Add(CategoryRequestDto newCategory)
        {
            var categoryEntity = new Category()
            {
                Name = newCategory.Name,

            };

            await _categories.AddAsync(categoryEntity);
            var saveEntity = await _categories.GetByIdAsync(categoryEntity.Id);
            return new CategoryResponseDto
            {
                Id = saveEntity.Id,
                Name = saveEntity.Name,
            };


        }

        public async Task Delete(long categoryId)
        {
            if (await DoesCategoryExists(categoryId))
            {
                await _categories.DeleteAsync(categoryId);
            }
            else
            {
                throw new Exception($"Category with Id :{categoryId} not found");
            }
        }

        public async Task<IEnumerable<CategoryResponseDto>> Get()
        {
            var entities = await _categories.ListAllAsync();
            var dtos = entities.Select(e => new CategoryResponseDto
            {
                Id = e.Id,
                Name = e.Name,
            });
            return dtos;
        }

        public async Task<IEnumerable<FishResponseDto>> GetByCategoryIdAsync(long id)
        {
            if (await DoesCategoryExists(id))
            {
                var fishs = await _categories.GetByCategoryIdAsync(id);


                return fishs.Select(f => new FishResponseDto
                {
                    Id = f.Id,
                    Name = f.Name,
                    OriginCountryId = f.OriginCountryId,
                    CategoryId = f.CategoryId,
                    CategoryName = f.Category.Name,
                    OriginCountryName = f.OriginCountry.Name,
                    DateOfArrival = f.DateOfArrival,
                    Price=f.Price,
                    MaxWeight=f.MaxWeight,
                    MinWeigth=f.MinWeigth,
                    UrlImage= CreateAbsolutePath(f?.UrlImage ?? "images/default.jpg"),
                });
            }
            else
            {
                throw new Exception($"Category with Id :{id} not found");
            }

        }

        public async Task<CategoryResponseDto> GetById(long id)
        {
            var categoryEntity = await _categories.GetByIdAsync(id);
            if (categoryEntity == null)
            {
                return null;
            }
            else
            {
                var categoryResponseDto = new CategoryResponseDto
                {
                    Id = categoryEntity.Id,
                    Name = categoryEntity.Name,

                };
                return categoryResponseDto;
            }
        }

        public async Task<CategoryResponseDto> Update(CategoryRequestDto existingCategory)
        {
            if (await DoesCategoryExists(existingCategory.Id))
            {
                var existingCategoryEntity = await _categories.GetByIdAsync(existingCategory.Id);

                existingCategoryEntity.Name = existingCategory.Name;

                await _categories.UpdateAsync(existingCategoryEntity);

                return new CategoryResponseDto
                {
                    Id=existingCategoryEntity.Id,
                    Name = existingCategoryEntity.Name,

                };

            }
            else
            {
                throw new Exception($"Category with Id :{existingCategory.Id} not found");
            }
        }
        private async Task<bool> DoesCategoryExists(long id)
        {
            var category = await _categories.GetByIdAsync(id);
            if (category == null) return false;
            else return true;
        }
        private string CreateAbsolutePath(string imagePath)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var scheme = request.Scheme;
            var rootUrl = request.Host;
            return $"{scheme}://{rootUrl}/{imagePath}";
        }
    }
}
