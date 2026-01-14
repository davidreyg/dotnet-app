using DE.Application.Interfaces;
using DE.Application.Interfaces.Repositories;
using DE.Infrastructure.Data.Contexts;
using DE.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DE.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInjectionInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var assembly = typeof(DbContextApp).Assembly.FullName;
        services.AddDbContext<DbContextApp>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(assembly)
            )
        );

        services.AddScoped<ApplicationDbContextInitializer>();
        services.AddRepositories();
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        //UOW
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        // Repositories
        services.AddScoped<IIdentityDocumentTypeRepository, IdentityDocumentTypeRepository>();
        services.AddScoped<IHealthServiceUnitRepository, HealthServiceUnitRepository>();
        services.AddScoped<IMedicalProcedureRepository, MedicalProcedureRepository>();
        services.AddScoped<IProfessionalCouncilRepository, ProfessionalCouncilRepository>();
        services.AddScoped<IContractTypeRepository, ContractTypeRepository>();

        return services;
    }
}
