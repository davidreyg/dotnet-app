using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class EmployeeService(IUnitOfWork uow) : IEmployeeService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<EmployeeResponse>> GetAllAsync()
    {
        var result = await _uow.EmployeeRepository.GetAllAsync();
        return result.Adapt<IEnumerable<EmployeeResponse>>();
    }
}
