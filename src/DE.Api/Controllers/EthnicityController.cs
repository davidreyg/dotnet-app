using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/etnias")]
[ApiController]
public class EthnicityController(IEthnicityService ethnicityService) : ControllerBase
{
    private readonly IEthnicityService _ethnicityService = ethnicityService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _ethnicityService.GetAllAsync();
        return Ok(response);
    }
}
