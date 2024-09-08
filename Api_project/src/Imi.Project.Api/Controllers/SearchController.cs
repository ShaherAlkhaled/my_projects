using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IFishService _fishService;

        public SearchController(IFishService fishService)
        {
            _fishService = fishService;
        }
        [HttpGet]
        [Authorize(Policy = "CanRead")]

        public async Task<IActionResult> Search([FromQuery] string search)
        {
            var response = await _fishService.SearchAsync(search);

            return Ok(response);
        }

    }
}
