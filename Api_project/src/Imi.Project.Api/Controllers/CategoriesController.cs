using Imi.Project.Api.Core.Dtos.Categories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        [Authorize(Policy = "CanRead")]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.Get();
            return Ok(categories);
        }


        [HttpGet("{id}")]
        [Authorize(Policy = "CanRead")]
        public async Task<IActionResult> GetById(long id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound($"Category is not found with id {id}");
            }

            else
            {
                return Ok(category);

            }
        }



        [HttpPost]
        [Authorize(Policy = "CanCreate")]

        public async Task<IActionResult> Post(CategoryRequestDto newCategory)
        {
            var savedCategory = await _categoryService.Add(newCategory);
            return Ok(savedCategory);
        }


        [HttpDelete("{categoryId}")]
        [Authorize(Policy = "CanDelete")]

        public async Task<IActionResult> DeleteById(long categoryId)
        {
            try
            {
                await _categoryService.Delete(categoryId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Policy = "CanEdit")]

        public async Task<IActionResult> Update(CategoryRequestDto existingCategroy)
        {
            try
            {
                var updatedCategory = await _categoryService.Update(existingCategroy);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}/Fishs")]
        [Authorize(Policy = "CanRead")]
        public async Task<IActionResult> GetFishByCategoryId(long id)
        {
            try
            {
                var fishs = await _categoryService.GetByCategoryIdAsync(id);
                return Ok(fishs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
