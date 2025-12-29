using DE.Api.Configuration;
using InfisicalConfiguration;

namespace DE.Api.Extensions;

public static class InfisicalServiceExtensions
{
    /// <summary>
    /// Adds Infisical as configuration provider
    /// </summary>
    public static WebApplicationBuilder AddInfisicalConfiguration(
        this WebApplicationBuilder builder
    )
    {
        var options = new InfisicalOptions();
        builder.Configuration.GetSection(options.SectionName).Bind(options);

        if (
            string.IsNullOrEmpty(options.ClientId)
            || string.IsNullOrEmpty(options.ClientSecret)
            || string.IsNullOrEmpty(options.ProjectId)
        )
        {
            builder.Logging.AddConsole().SetMinimumLevel(LogLevel.Warning);
            var logger = LoggerFactory
                .Create(logging => logging.AddConsole())
                .CreateLogger("Infisical");

            logger.LogWarning(
                "Infisical not configured yet!. Make sure to configure ClientId, ClientSecret y ProjectId "
                    + "as environment variables or User Secrets for development."
            );

            return builder;
        }

        try
        {
            builder
                .Configuration.SetBasePath(builder.Environment.ContentRootPath)
                .AddInfisical(
                    new InfisicalConfigBuilder()
                        .SetProjectId(options.ProjectId)
                        .SetEnvironment(options.Environment)
                        .SetSecretPath(options.SecretPath) // Optional, defaults to "/"
                        .SetInfisicalUrl(options.SiteUrl) // Optional, defaults to https://infisical.com
                        .SetAuth(
                            new InfisicalAuthBuilder()
                                .SetUniversalAuth(options.ClientId, options.ClientSecret)
                                .Build()
                        )
                        .Build()
                )
                .Build();

            builder.Services.AddLogging(logging =>
            {
                logging.AddConsole();
            });

            var logger = LoggerFactory
                .Create(logging => logging.AddConsole())
                .CreateLogger("Infisical");

            logger.LogInformation(
                "Infisical configured. Project: {ProjectId}, Environment: {Environment}",
                options.ProjectId,
                options.Environment
            );
        }
        catch (Exception ex)
        {
            var logger = LoggerFactory
                .Create(logging => logging.AddConsole())
                .CreateLogger("Infisical");

            logger.LogError(ex, "Error configuring Infisical. Continue without Infisical secrets.");
        }

        return builder;
    }
}
