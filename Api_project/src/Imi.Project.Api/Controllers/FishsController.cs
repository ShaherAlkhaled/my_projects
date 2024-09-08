using Imi.Project.Api.Core.Dtos.Fishs;
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
    public class FishsController : ControllerBase
    {
        private readonly IFishService _fishService;

        public FishsController(IFishService fishService)
        {
            _fishService = fishService;
        }

        [HttpGet]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> Get()
        {
            var fishs = await _fishService.Get();
            return Ok(fishs);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> GetById(long id)
        {
            var fish = await _fishService.GetById(id);
            if (fish == null)
            {
                return NotFound($"fish is not found with id {id}");
            }

            else
            {
                return Ok(fish);

            }
        }


        [HttpPost]
        [Authorize(Policy = "CanCreate")]

        public async Task<IActionResult> Post(FishRequestDto newFish)
        {
            try
            {
                var savedFish = await _fishService.Add(newFish);
                return Ok(savedFish);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{fishId}")]
        [Authorize(Policy = "CanDelete")]

        public async Task<IActionResult> DeleteById(long fishId)
        {
            try
            {
                await _fishService.Delete(fishId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Policy = "CanEdit")]

        public async Task<IActionResult> Update(FishRequestDto existingFish)
        {
            try
            {
                var updatedFish = await _fishService.Update(existingFish);
                return Ok(updatedFish);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("{id}/image")]
        [Authorize(Policy = "CanCreate")]

        [HttpPut("{id}/image")]
        [Authorize(Policy = "CanEdit")]

        public async Task<IActionResult> UploadImage([FromRoute] long id, IFormFile file)
        {
            try
            {
                var response = await _fishService.AddOrUpdateImageAsync(id, file);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
         ;
        }

    }
}
