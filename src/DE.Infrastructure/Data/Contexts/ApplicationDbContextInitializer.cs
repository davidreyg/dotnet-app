using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DE.Domain.Entities;
using DE.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DE.Infrastructure.Data.Contexts
{
    public class ApplicationDbContextInitializer
    {
        private readonly ILogger<ApplicationDbContextInitializer> _logger;
        private readonly DbContextApp _context;

        public ApplicationDbContextInitializer(
            ILogger<ApplicationDbContextInitializer> logger,
            DbContextApp context
        )
        {
            _logger = logger;
            _context = context;
        }

        public async Task InitializeAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initializing the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        private static async Task SeedEntityFromCsv<TEntity, TMap>(
            string fileName,
            DbSet<TEntity> dbSet
        )
            where TEntity : class
            where TMap : ClassMap<TEntity>
        {
            if (!await dbSet.AnyAsync())
            {
                var path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Data",
                    "Seeds",
                    fileName
                );

                if (!File.Exists(path))
                    return;

                using var reader = new StreamReader(path);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

                csv.Context.RegisterClassMap<TMap>();

                var records = csv.GetRecords<TEntity>().ToList();
                await dbSet.AddRangeAsync(records);
            }
        }

        public async Task TrySeedAsync()
        {
            await SeedEntityFromCsv<Country, CountryMap>("Countries.csv", _context.Country);
            await SeedEntityFromCsv<ContractType, ContractTypeMap>(
                "ContractTypes.csv",
                _context.ContractType
            );
            await SeedEntityFromCsv<Establishment, EstablishmentMap>(
                "Establishments.csv",
                _context.Establishment
            );
            await SeedEntityFromCsv<Ethnicity, EthnicityMap>("Ethnicities.csv", _context.Ethnicity);
            await SeedEntityFromCsv<ExtraCondition, ExtraConditionMap>(
                "ExtraConditions.csv",
                _context.ExtraCondition
            );
            await SeedEntityFromCsv<Financier, FinancierMap>("Financiers.csv", _context.Financier);
            await SeedEntityFromCsv<HealthServiceUnit, HealthServiceUnitMap>(
                "HealthServiceUnits.csv",
                _context.HealthServiceUnit
            );
            await SeedEntityFromCsv<MedicalProcedure, MedicalProcedureMap>(
                "MedicalProcedures.csv",
                _context.MedicalProcedure
            );
            await SeedEntityFromCsv<DocumentType, DocumentTypeMap>(
                "DocumentTypes.csv",
                _context.DocumentType
            );
            await SeedEntityFromCsv<ProfessionalCouncil, ProfessionalCouncilMap>(
                "ProfessionalCouncils.csv",
                _context.ProfessionalCouncil
            );
            await SeedEntityFromCsv<Profession, ProfessionMap>(
                "Professions.csv",
                _context.Profession
            );
            await SeedEntityFromCsv<SisProcedure, SisProcedureMap>(
                "SisProcedures.csv",
                _context.SisProcedure
            );
            await SeedEntityFromCsv<Tariff, TariffMap>("Tariffs.csv", _context.Tariff);
            await _context.SaveChangesAsync();
            if (!_context.IdentityDocumentType.Any())
            {
                _context.IdentityDocumentType.AddRange(
                    new IdentityDocumentType
                    {
                        Code = "DNI",
                        Description = "Documento Nacional de Identidad",
                        Status = 1,
                    },
                    new IdentityDocumentType
                    {
                        Code = "RUC",
                        Description = "Registro Unico de Contribuyente",
                        Status = 1,
                    },
                    new IdentityDocumentType
                    {
                        Code = "CE",
                        Description = "Carné de Extranjería",
                        Status = 1,
                    },
                    new IdentityDocumentType
                    {
                        Code = "PASAPORTE",
                        Description = "Pasaporte",
                        Status = 1,
                    },
                    new IdentityDocumentType
                    {
                        Code = "OTROS",
                        Description = "Otros",
                        Status = 1,
                    }
                );

                await _context.SaveChangesAsync();
            }
        }
    }
}
