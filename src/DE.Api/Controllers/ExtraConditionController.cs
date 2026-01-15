using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/otras-condiciones")]
[ApiController]
public class ExtraConditionController(IExtraConditionService extraConditionService) : ControllerBase
{
    private readonly IExtraConditionService _extraConditionService = extraConditionService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _extraConditionService.GetAllAsync();
        return Ok(response);
    }
}
