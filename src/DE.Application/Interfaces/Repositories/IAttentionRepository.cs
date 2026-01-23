using DE.Domain.Entities;
using Sieve.Models;

namespace DE.Application.Interfaces.Repositories;

public interface IAttentionRepository : IGenericRepository<Attention>
{
    public Task<int> GetCountAsync(SieveModel model);
}
