using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class FinancierService(IUnitOfWork uow) : IFinancierService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<FinancierResponse>> GetAllAsync()
    {
        var result = await _uow.FinancierRepository.GetAllAsync();
        return result.Adapt<IEnumerable<FinancierResponse>>();
    }
}
