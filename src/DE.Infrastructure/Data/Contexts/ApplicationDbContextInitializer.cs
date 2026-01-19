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
            DbSet<TEntity> dbSet,
            DbContext context,
            int chunkSize = 10000
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

                var records = csv.GetRecords<TEntity>();
                var chunk = new List<TEntity>(chunkSize);
                var totalProcessed = 0;

                foreach (var record in records)
                {
                    chunk.Add(record);

                    if (chunk.Count >= chunkSize)
                    {
                        await dbSet.AddRangeAsync(chunk);
                        await context.SaveChangesAsync();

                        totalProcessed += chunk.Count;
                        Console.WriteLine($"Total processed: {totalProcessed} from {fileName}...");

                        chunk.Clear();
                        context.ChangeTracker.Clear();
                    }
                }

                if (chunk.Count > 0)
                {
                    await dbSet.AddRangeAsync(chunk);
                    await context.SaveChangesAsync();

                    totalProcessed += chunk.Count;
                    Console.WriteLine($"Total: {totalProcessed} from {fileName}");
                }
            }
        }

        public async Task TrySeedAsync()
        {
            await SeedEntityFromCsv<Country, CountryMap>(
                "Countries.csv",
                _context.Country,
                _context
            );
            await SeedEntityFromCsv<ContractType, ContractTypeMap>(
                "ContractTypes.csv",
                _context.ContractType,
                _context
            );
            await SeedEntityFromCsv<Establishment, EstablishmentMap>(
                "Establishments.csv",
                _context.Establishment,
                _context
            );
            await SeedEntityFromCsv<Ethnicity, EthnicityMap>(
                "Ethnicities.csv",
                _context.Ethnicity,
                _context
            );
            await SeedEntityFromCsv<ExtraCondition, ExtraConditionMap>(
                "ExtraConditions.csv",
                _context.ExtraCondition,
                _context
            );
            await SeedEntityFromCsv<Financier, FinancierMap>(
                "Financiers.csv",
                _context.Financier,
                _context
            );
            await SeedEntityFromCsv<HealthServiceUnit, HealthServiceUnitMap>(
                "HealthServiceUnits.csv",
                _context.HealthServiceUnit,
                _context
            );
            await SeedEntityFromCsv<MedicalProcedure, MedicalProcedureMap>(
                "MedicalProcedures.csv",
                _context.MedicalProcedure,
                _context
            );
            await SeedEntityFromCsv<DocumentType, DocumentTypeMap>(
                "DocumentTypes.csv",
                _context.DocumentType,
                _context
            );
            await SeedEntityFromCsv<ProfessionalCouncil, ProfessionalCouncilMap>(
                "ProfessionalCouncils.csv",
                _context.ProfessionalCouncil,
                _context
            );
            await SeedEntityFromCsv<Profession, ProfessionMap>(
                "Professions.csv",
                _context.Profession,
                _context
            );
            await SeedEntityFromCsv<SisProcedure, SisProcedureMap>(
                "SisProcedures.csv",
                _context.SisProcedure,
                _context
            );
            await SeedEntityFromCsv<Tariff, TariffMap>("Tariffs.csv", _context.Tariff, _context);
        }
    }
}
