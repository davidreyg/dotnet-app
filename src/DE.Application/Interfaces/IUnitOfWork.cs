using DE.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace DE.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    //Her Added
    IIdentityDocumentTypeRepository IdentityDocumentTypes { get; }
    IHealthServiceUnitRepository HealthServiceUnitRepository { get; }
    IMedicalProcedureRepository MedicalProcedureRepository { get; }
    IProfessionalCouncilRepository ProfessionalCouncilRepository { get; }
    IContractTypeRepository ContractTypeRepository { get; }
    IEstablishmentRepository EstablishmentRepository { get; }
    IEthnicityRepository EthnicityRepository { get; }
    IFinancierRepository FinancierRepository { get; }
    IExtraConditionRepository ExtraConditionRepository { get; }
    ICountryRepository CountryRepository { get; }
    IProfessionRepository ProfessionRepository { get; }
    IEmployeeRepository EmployeeRepository { get; }
    ISisProcedureRepository SisProcedureRepository { get; }
    ITariffRepository TariffRepository { get; }
    IAttentionRepository AttentionRepository { get; }

    Task<int> SaveChangesAsync();
    Task<IDbContextTransaction> BeginTransactionAsync();
}
