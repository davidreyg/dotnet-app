using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers;

[Route("api/empleados")]
[ApiController]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    private readonly IEmployeeService _employeeService = employeeService;

    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAll()
    {
        var response = await _employeeService.GetAllAsync();
        return Ok(response);
    }
}
