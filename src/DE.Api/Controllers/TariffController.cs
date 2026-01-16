using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/tarifario-sis")]
[ApiController]
public class TariffController(ITariffService tariffService) : ControllerBase
{
    private readonly ITariffService _tariffService = tariffService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _tariffService.GetAllAsync();
        return Ok(response);
    }
}
