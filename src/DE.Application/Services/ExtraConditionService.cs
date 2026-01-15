using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class ExtraConditionService(IUnitOfWork uow) : IExtraConditionService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<ExtraConditionResponse>> GetAllAsync()
    {
        var result = await _uow.ExtraConditionRepository.GetAllAsync();
        return result.Adapt<IEnumerable<ExtraConditionResponse>>();
    }
}
