using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers
{
    [Route("api/ups")]
    [ApiController]
    public class UpsController(IUpsService upsService) : ControllerBase
    {
        private readonly IUpsService _upsService = upsService;

        [Authorize]
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var response = await _upsService.GetAllAsync();
            return Ok(response);
        }
    }
}
