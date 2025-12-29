using DE.Api.Configuration;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;

namespace DE.Api.Extensions;

public static class OpenApiServiceExtensions
{
    /// <summary>
    /// Register OpenAPI service in Dependency Container.
    /// /// </summary>
    public static WebApplicationBuilder AddOpenApiDocumentation(this WebApplicationBuilder builder)
    {
        var openApiConfiguration = builder
            .Configuration.GetSection(OpenApiConfiguration.SectionName)
            .Get<OpenApiConfiguration>()!;
        var oauthConfiguration = builder
            .Configuration.GetSection(OAuthConfiguration.SectionName)
            .Get<OAuthConfiguration>()!;

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

                    // OAuth Configuration
                    document.Components ??= new();
                    document.Components.SecuritySchemes ??=
                        new Dictionary<string, OpenApiSecurityScheme>();
                    document.Components.SecuritySchemes.Add(
                        "oauth2",
                        new()
                        {
                            Type = SecuritySchemeType.OAuth2,
                            Flows = new()
                            {
                                AuthorizationCode = new()
                                {
                                    AuthorizationUrl = new Uri(oauthConfiguration.AuthorizationUrl),
                                    TokenUrl = new Uri(oauthConfiguration.TokenUrl),
                                    // Scopes = scalarOptions.OAuth.Scopes.ToDictionary(
                                    //     s => s,
                                    //     s => $"Access to {s}"
                                    // ),
                                    Scopes = new Dictionary<string, string>
                                    {
                                        { "api.read", "Read access to API" },
                                        { "api.write", "Write access to API" },
                                    },
                                },
                            },
                        }
                    );

                    document.SecurityRequirements = new List<OpenApiSecurityRequirement>
                    {
                        new()
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new()
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "oauth2",
                                    },
                                },
                                Array.Empty<string>()
                            },
                        },
                    };
                    return Task.CompletedTask;
                }
            );
        });

        return builder;
    }

    /// <summary>
    /// Configures OpenAPI middleware & Scalar App Pipeline
    /// </summary>
    public static IApplicationBuilder UseOpenApiDocumentation(this WebApplication app)
    {
        var openApiConfiguration = app
            .Configuration.GetSection(OpenApiConfiguration.SectionName)
            .Get<OpenApiConfiguration>()!;
        var oAuthConfiguration = app
            .Configuration.GetSection(OAuthConfiguration.SectionName)
            .Get<OAuthConfiguration>()!;

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
                    .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient)
                    .AddPreferredSecuritySchemes("OAuth2");
                options.AddImplicitFlow(
                    "OAuth2",
                    flow =>
                    {
                        flow.ClientId = oAuthConfiguration.ClientId;
                        flow.SelectedScopes = ["api.read", "api.write"];
                    }
                );

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
