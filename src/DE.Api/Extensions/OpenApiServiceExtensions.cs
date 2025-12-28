using DE.Api.Configuration;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;

namespace DE.Api.Extensions;

public static class OpenApiServiceExtensions
{
    /// <summary>
    /// Register OpenAPI service in Dependency Container.
    /// /// </summary>
    public static IServiceCollection AddOpenApiDocumentation(this IServiceCollection services)
    {
        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer(
                (document, context, cancellationToken) =>
                {
                    document.Info = new OpenApiInfo
                    {
                        Title = OpenApiConfiguration.Title,
                        Version = OpenApiConfiguration.Version,
                        Description = OpenApiConfiguration.Description,
                        Contact = new OpenApiContact
                        {
                            Name = OpenApiConfiguration.Contact.Name,
                            Email = OpenApiConfiguration.Contact.Email,
                            Url = new Uri(OpenApiConfiguration.Contact.Url),
                        },
                        License = new OpenApiLicense
                        {
                            Name = OpenApiConfiguration.License.Name,
                            Url = new Uri(OpenApiConfiguration.License.Url),
                        },
                    };

                    return Task.CompletedTask;
                }
            );
        });

        return services;
    }

    /// <summary>
    /// Configures OpenAPI middleware & Scalar App Pipeline
    /// </summary>
    public static IApplicationBuilder UseOpenApiDocumentation(this WebApplication app)
    {
        // Enable only in Development y Staging
        if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
        {
            // Map OpenAPI endpoints
            app.MapOpenApi();

            // Scalar UI configuration
            app.MapScalarApiReference(options =>
            {
                options
                    .WithTitle(OpenApiConfiguration.Title)
                    .WithTheme(ScalarTheme.BluePlanet)
                    .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);

                options.ShowSidebar = OpenApiConfiguration.Scalar.ShowSidebar;
                options.DarkMode = OpenApiConfiguration.Scalar.DarkMode;
            });
        }

        return app;
    }
}
