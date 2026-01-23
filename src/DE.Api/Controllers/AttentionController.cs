using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;

namespace DE.Api.Controllers;

[Route("api/atenciones")]
[ApiController]
public class AttentionController(IAttentionService attentionService) : ControllerBase
{
    private readonly IAttentionService _attentionService = attentionService;

    [Authorize]
    [HttpGet("metricas")]
    public async Task<IActionResult> GetAll([FromQuery] SieveModel model)
    {
        var response = await _attentionService.GetMetricsCountAsync(model);
        return Ok(response);
    }
}
