using System;
using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Mapster;

namespace DE.Application.Services;

public class EstablishmentService(IUnitOfWork uow) : IEstablishmentService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<IEnumerable<EstablishmentResponse>> GetAllAsync()
    {
        var result = await _uow.EstablishmentRepository.GetAllAsync();
        return result.Adapt<IEnumerable<EstablishmentResponse>>();
    }
}
