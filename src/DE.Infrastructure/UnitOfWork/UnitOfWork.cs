using DE.Application.Interfaces;
using DE.Application.Interfaces.Repositories;
using DE.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

// FIXME: Must be DE.Infrastructure.UnitOfWork but it imports as a namespace not a class
namespace DE.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContextApp _context;
    public IIdentityDocumentTypeRepository IdentityDocumentTypes { get; }

    public IHealthServiceUnitRepository HealthServiceUnitRepository { get; }

    public IMedicalProcedureRepository MedicalProcedureRepository { get; }

    public IProfessionalCouncilRepository ProfessionalCouncilRepository { get; }

    public IContractTypeRepository ContractTypeRepository { get; }

    //public IGenericRepository<IdentityDocumentType> IdentityDocumentType { get; }

    public UnitOfWork(
        DbContextApp context,
        IIdentityDocumentTypeRepository identityDocumentTypeRepository,
        IHealthServiceUnitRepository healthServiceUnitRepository,
        IMedicalProcedureRepository medicalProcedureRepository,
        IProfessionalCouncilRepository professionalCouncilRepository,
        IContractTypeRepository contractTypeRepository
    )
    {
        _context = context;
        IdentityDocumentTypes = identityDocumentTypeRepository;
        HealthServiceUnitRepository = healthServiceUnitRepository;
        MedicalProcedureRepository = medicalProcedureRepository;
        ProfessionalCouncilRepository = professionalCouncilRepository;
        ContractTypeRepository = contractTypeRepository;
        //IdentityDocumentType = new GenericRepository<IdentityDocumentType>(context);
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

    public async Task<IDbContextTransaction> BeginTransactionAsync() =>
        await _context.Database.BeginTransactionAsync();

    public void Dispose() => _context.Dispose();
}
