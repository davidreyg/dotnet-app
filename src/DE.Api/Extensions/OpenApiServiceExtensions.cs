using DE.Api.Configuration;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;

namespace DE.Api.Extensions;

public static class OpenApiServiceExtensions
{
    /// <summary>
    /// Register OpenAPI service in Dependency Container.
    /// /// </summary>
    public static IServiceCollection AddOpenApiDocumentation(this WebApplicationBuilder builder)
    {
        var openApiConfiguration = builder
            .Configuration.GetSection(OpenApiConfiguration.SectionName)
            .Get<OpenApiConfiguration>()!;

        builder.Services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer(
                (document, context, cancellationToken) =>
                {
                    document.Info = new OpenApiInfo
                    {
                        Title = openApiConfiguration.Title,
                        Version = openApiConfiguration.Version,
                        Description = openApiConfiguration.Description,
                        Contact = new OpenApiContact
                        {
                            Name = openApiConfiguration.Contact.Name,
                            Email = openApiConfiguration.Contact.Email,
                            Url = new Uri(openApiConfiguration.Contact.Url),
                        },
                        License = new OpenApiLicense
                        {
                            Name = openApiConfiguration.License.Name,
                            Url = new Uri(openApiConfiguration.License.Url),
                        },
                    };

                    return Task.CompletedTask;
                }
            );
        });

        return builder.Services;
    }

    /// <summary>
    /// Configures OpenAPI middleware & Scalar App Pipeline
    /// </summary>
    public static IApplicationBuilder UseOpenApiDocumentation(this WebApplication app)
    {
        var openApiConfiguration = app
            .Configuration.GetSection(OpenApiConfiguration.SectionName)
            .Get<OpenApiConfiguration>()!;

        // Enable only in Development y Staging
        if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
        {
            // Map OpenAPI endpoints
            app.MapOpenApi();

            // Scalar UI configuration
            app.MapScalarApiReference(options =>
            {
                options
                    .WithTitle(openApiConfiguration.Title)
                    .WithTheme(GetScalarTheme(openApiConfiguration.Scalar.Theme))
                    .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);

                options.ShowSidebar = openApiConfiguration.Scalar.ShowSidebar;
                options.DarkMode = openApiConfiguration.Scalar.DarkMode;
            });
        }

        return app;
    }

    private static ScalarTheme GetScalarTheme(string theme)
    {
        return theme.ToLower() switch
        {
            "purple" => ScalarTheme.Purple,
            "bluePlanet" => ScalarTheme.BluePlanet,
            "deepSpace" => ScalarTheme.DeepSpace,
            "saturn" => ScalarTheme.Saturn,
            "kepler" => ScalarTheme.Kepler,
            "mars" => ScalarTheme.Mars,
            "moon" => ScalarTheme.Moon,
            "default" => ScalarTheme.Default,
            _ => ScalarTheme.Purple,
        };
    }
}
