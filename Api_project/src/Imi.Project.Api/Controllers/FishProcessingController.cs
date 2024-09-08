using Imi.Project.Api.Core.Dtos.FishProcessing;
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
    public class FishProcessingController : ControllerBase
    {
        private readonly IFishProcessingService _fishProcessingService;

        public FishProcessingController(IFishProcessingService fishProcessingService)
        {
            _fishProcessingService = fishProcessingService;
        }

        [HttpGet]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> Get()
        {
            var processings = await _fishProcessingService.Get();
            return Ok(processings);
        }


        [HttpGet("{id}")]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> GetById(long id)
        {
            var processing = await _fishProcessingService.GetById(id);
            if (processing == null)
            {
                return NotFound($"FishProcessing is not found with id {id}");
            }

            else
            {
                return Ok(processing);

            }
        }



        [HttpPost]
        [Authorize(Policy = "CanCreate")]

        public async Task<IActionResult> Post(FishProcessingRequestDto newCountry)
        {
            try
            {
                var savedProcessing = await _fishProcessingService.Add(newCountry);
                return Ok(savedProcessing);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpDelete("{fishProcessingId}")]
        [Authorize(Policy = "CanDelete")]

        public async Task<IActionResult> DeleteById(long fishProcessingId)
        {
            try
            {
                await _fishProcessingService.Delete(fishProcessingId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Policy = "CanEdit")]

        public async Task<IActionResult> Update(FishProcessingRequestDto existingProcessing)
        {
            try
            {
                var updatedProcessing = await _fishProcessingService.Update(existingProcessing);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/Fishs")]
        [Authorize(Policy = "CanRead")]


        public async Task<IActionResult> GetFishByProcessingId(long id)
        {
            try
            {
                var fishs = await _fishProcessingService.GetByProcessingIdAsync(id);
                return Ok(fishs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
