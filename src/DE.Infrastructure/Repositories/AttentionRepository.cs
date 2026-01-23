using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;

namespace DE.Infrastructure.Repositories;

public class AttentionRepository : GenericRepository<Attention>, IAttentionRepository
{
    private readonly ISieveProcessor _sieveProcessor;

    public AttentionRepository(DbContextApp context, ISieveProcessor sieveProcessor)
        : base(context)
    {
        _sieveProcessor = sieveProcessor;
    }

    public async Task<int> GetAllAttentionsCount(SieveModel model)
    {
        var query = _dbSet.AsNoTracking();
        query = _sieveProcessor.Apply(model, query, applyPagination: false);
        return await query.CountAsync();
    }

    public async Task<int> GetAttendedPatientsCount(SieveModel model)
    {
        var query = _dbSet.AsNoTracking();
        query = _sieveProcessor.Apply(model, query, applyPagination: false);
        return await query.Select(a => a.PatientCode).Distinct().CountAsync();
    }
}
