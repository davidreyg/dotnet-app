using System.Reflection;
using DE.Application.Interfaces.Common;
using DE.Application.Interfaces.Services;
using DE.Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DE.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddScoped<IValidationService, ValidationService>();

        services.AddScoped<IIdentityDocumentTypeService, IdentityDocumentTypeService>();
        services.AddScoped<IHealthServiceUnitService, HealthServiceUnitService>();
        services.AddScoped<IMedicalProcedureService, MedicalProcedureService>();
        services.AddScoped<IProfessionalCouncilService, ProfessionalCouncilService>();
        services.AddScoped<IContractTypeService, ContractTypeService>();
        services.AddScoped<IEstablishmentService, EstablishmentService>();
        services.AddScoped<IEthnicityService, EthnicityService>();
        services.AddScoped<IFinancierService, FinancierService>();
        services.AddScoped<IExtraConditionService, ExtraConditionService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<IProfessionService, ProfessionService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        return services;
    }
}
