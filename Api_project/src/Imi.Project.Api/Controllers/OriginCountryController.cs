using Imi.Project.Api.Core.Dtos.OriginCountries;
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
    public class OriginCountryController : ControllerBase
    {
        private readonly IOriginCountryService _originCountryService;

        public OriginCountryController(IOriginCountryService originCountryService)
        {
            _originCountryService = originCountryService;
        }

        [HttpGet]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> Get()
        {
            var countries = await _originCountryService.Get();
            return Ok(countries);
        }


        [HttpGet("{id}")]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> GetById(long id)
        {
            var country = await _originCountryService.GetById(id);
            if (country == null)
            {
                return NotFound($"Country is not found with id {id}");
            }

            else
            {
                return Ok(country);

            }
        }



        [HttpPost]
        [Authorize(Policy = "CanCreate")]

        public async Task<IActionResult> Post(OriginCountryRequestDto newCountry)
        {
            var savedCountry = await _originCountryService.Add(newCountry);
            return Ok(savedCountry);
        }


        [HttpDelete("{countryId}")]
        [Authorize(Policy = "CanDelete")]

        public async Task<IActionResult> DeleteById(long countryId)
        {
            try
            {
                await _originCountryService.Delete(countryId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Policy = "CanEdit")]

        public async Task<IActionResult> Update(OriginCountryRequestDto existingCountry)
        {
            try
            {
                var updatedCountry = await _originCountryService.Update(existingCountry);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/Fishs")]
        [Authorize(Policy = "CanRead")]
        public async Task<IActionResult> GetByOriginCountryIdAsync(long id)
        {
            try
            {
                var fishs = await _originCountryService.GetByOriginCountryIdAsync(id);
                return Ok(fishs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
