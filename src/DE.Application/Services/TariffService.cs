using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class TariffService(IUnitOfWork uow) : ITariffService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<TariffResponse>> GetAllAsync()
    {
        var result = await _uow.TariffRepository.GetAllAsync();
        return result.Adapt<IEnumerable<TariffResponse>>();
    }
}
