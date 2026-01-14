using System;
using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/professional-councils")]
[ApiController]
public class ProfessionalCouncilController(IProfessionalCouncilService professionalCouncilService)
    : ControllerBase
{
    private readonly IProfessionalCouncilService _professionalCouncilService =
        professionalCouncilService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _professionalCouncilService.GetAllAsync();
        return Ok(response);
    }
}
