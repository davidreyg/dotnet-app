using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/procedimientos-sis")]
[ApiController]
public class SisProcedureController(ISisProcedureService sisProcedureService) : ControllerBase
{
    private readonly ISisProcedureService _sisProcedureService = sisProcedureService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _sisProcedureService.GetAllAsync();
        return Ok(response);
    }
}
