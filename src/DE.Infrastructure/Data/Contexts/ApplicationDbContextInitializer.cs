using DE.Domain.Entities;
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

        public async Task TrySeedAsync()
        {
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
