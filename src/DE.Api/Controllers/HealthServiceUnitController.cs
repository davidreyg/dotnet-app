using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers
{
    [Route("api/ups")]
    [ApiController]
    public class HealthServiceUnitController(IHealthServiceUnitService healthServiceUnitService)
        : ControllerBase
    {
        private readonly IHealthServiceUnitService _healthServiceUnitService =
            healthServiceUnitService;

        [Authorize]
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var response = await _healthServiceUnitService.GetAllAsync();
            return Ok(response);
        }
    }
}
