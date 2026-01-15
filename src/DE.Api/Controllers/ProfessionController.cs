using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/profesiones")]
[ApiController]
public class ProfessionController(IProfessionService professionService) : ControllerBase
{
    private readonly IProfessionService _professionalService = professionService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _professionalService.GetAllAsync();
        return Ok(response);
    }
}
