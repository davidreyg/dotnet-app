using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class MedicalProcedureService(IUnitOfWork uow) : IMedicalProcedureService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<MedicalProcedureResponse>> GetAllAsync()
    {
        var result = await _uow.MedicalProcedureRepository.GetAllAsync();
        return result.Adapt<IEnumerable<MedicalProcedureResponse>>();
    }
}
