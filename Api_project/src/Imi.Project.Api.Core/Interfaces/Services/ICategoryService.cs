using Imi.Project.Api.Core.Dtos.Categories;
using Imi.Project.Api.Core.Dtos.Fishs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDto>> Get();
        Task<CategoryResponseDto> GetById(long id);
        Task<CategoryResponseDto> Add(CategoryRequestDto newCategory);
        Task Delete(long categoryId);
        Task<CategoryResponseDto> Update(CategoryRequestDto existingCategory);
        Task<IEnumerable<FishResponseDto>> GetByCategoryIdAsync(long id);

    }
}
