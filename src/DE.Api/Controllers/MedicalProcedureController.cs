using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/cpms")]
[ApiController]
public class MedicalProcedureController(IMedicalProcedureService medicalProcedureService)
    : ControllerBase
{
    private readonly IMedicalProcedureService _medicalProcedureService = medicalProcedureService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _medicalProcedureService.GetAllAsync();
        return Ok(response);
    }
}
