using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class EthnicityService(IUnitOfWork uow) : IEthnicityService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<EthnicityResponse>> GetAllAsync()
    {
        var result = await _uow.EthnicityRepository.GetAllAsync();
        return result.Adapt<IEnumerable<EthnicityResponse>>();
    }
}
