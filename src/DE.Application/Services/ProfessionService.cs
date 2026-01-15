using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class ProfessionService(IUnitOfWork uow) : IProfessionService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<ProfessionResponse>> GetAllAsync()
    {
        var result = await _uow.ProfessionRepository.GetAllAsync();
        return result.Adapt<IEnumerable<ProfessionResponse>>();
    }
}
