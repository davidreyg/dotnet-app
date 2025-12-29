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
        return services;
    }
}
