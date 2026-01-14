using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class CpmsService(IUnitOfWork uow) : ICpmsService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<CpmsResponse>> GetAllAsync()
    {
        var result = await _uow.CpmsRepository.GetAllAsync();
        return result.Adapt<IEnumerable<CpmsResponse>>();
    }
}
