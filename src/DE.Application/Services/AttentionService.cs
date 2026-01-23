using DE.Application.DTOs.Response;
using DE.Application.Interfaces;
using DE.Application.Interfaces.Services;
using Sieve.Models;

namespace DE.Application.Services;

public class AttentionService(IUnitOfWork uow) : IAttentionService
{
    private readonly IUnitOfWork _uow = uow;

    public async Task<AttentionMetricsResponse> GetCountsAsync(SieveModel sieveModel)
    {
        var attentions = await _uow.AttentionRepository.GetCountAsync(sieveModel);
        return new AttentionMetricsResponse(attentions, 0, 0, 0);
    }
}
