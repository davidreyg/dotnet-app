using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers
{
    [Route("api/ups")]
    [ApiController]
    public class HealthServiceUnitController(IHealthServiceUnitService healthServiceService)
        : ControllerBase
    {
        private readonly IHealthServiceUnitService _healthServiceService = healthServiceService;

        [Authorize]
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var response = await _healthServiceService.GetAllAsync();
            return Ok(response);
        }
    }
}
