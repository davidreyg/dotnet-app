using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/cpms")]
[ApiController]
public class CpmsController(ICpmsService cpmsService) : ControllerBase
{
    private readonly ICpmsService _cpmsService = cpmsService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _cpmsService.GetAllAsync();
        return Ok(response);
    }
}
