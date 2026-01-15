using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/financiamientos")]
[ApiController]
public class FinancierController(IFinancierService financierService) : ControllerBase
{
    private readonly IFinancierService _financierService = financierService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _financierService.GetAllAsync();
        return Ok(response);
    }
}
