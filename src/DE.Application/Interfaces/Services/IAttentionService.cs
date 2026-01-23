using DE.Application.DTOs.Response;
using Sieve.Models;

namespace DE.Application.Interfaces.Services;

public interface IAttentionService
{
    Task<AttentionMetricsResponse> GetMetricsCountAsync(SieveModel sieveModel);
}
