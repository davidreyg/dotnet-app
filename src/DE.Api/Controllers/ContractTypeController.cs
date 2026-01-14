using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/tipo-contratos")]
[ApiController]
public class ContractTypeController(IContractTypeService contractTypeService) : ControllerBase
{
    private readonly IContractTypeService _contractTypeService = contractTypeService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _contractTypeService.GetAllAsync();
        return Ok(response);
    }
}
