using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class ProfessionalCouncilService(IUnitOfWork uow) : IProfessionalCouncilService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<ProfessionalCouncilResponse>> GetAllAsync()
    {
        var result = await _uow.ProfessionalCouncilRepository.GetAllAsync();
        return result.Adapt<IEnumerable<ProfessionalCouncilResponse>>();
    }
}
