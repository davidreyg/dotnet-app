using DE.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace DE.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    //Her Added
    IIdentityDocumentTypeRepository IdentityDocumentTypes { get; }
    IHealthServiceUnitRepository HealthServiceUnitRepository { get; }
    IMedicalProcedureRepository MedicalProcedureRepository { get; }

    Task<int> SaveChangesAsync();
    Task<IDbContextTransaction> BeginTransactionAsync();
}
