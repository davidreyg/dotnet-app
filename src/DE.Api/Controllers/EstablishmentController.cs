using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/establecimientos")]
[ApiController]
public class EstablishmentController(IEstablishmentService establishmentService) : ControllerBase
{
    private readonly IEstablishmentService _establishmentService = establishmentService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _establishmentService.GetAllAsync();
        return Ok(response);
    }
}
