using DE.Application.Interfaces.Repositories;
using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace DE.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    //Her Added
    IIdentityDocumentTypeRepository IdentityDocumentTypes { get; }

    Task<int> SaveChangesAsync();
    Task<IDbContextTransaction> BeginTransactionAsync();
}
