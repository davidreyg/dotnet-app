using DE.Api.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace DE.Api.Extensions;

public static class AuthenticationServiceExtensions
{
    public static IServiceCollection AddAuthInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddAuthentication(configuration);
        services.AddCurrentUser();

        return services;
    }

    private static IServiceCollection AddAuthentication(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var oAuthConfiguration =
            configuration.GetSection(OAuthConfiguration.SectionName).Get<OAuthConfiguration>()
            ?? throw new InvalidOperationException("Authentication settings are not configured");

        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = oAuthConfiguration.Authority;
                options.Audience = oAuthConfiguration.Audience;
                options.RequireHttpsMetadata = oAuthConfiguration.RequireHttpsMetadata;
                options.MetadataAddress = oAuthConfiguration.MetadataAddress;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = false,
                    ValidIssuers =
                    [
                        oAuthConfiguration.ValidIssuer,
                        "http://auth.daregu.local/application/o/dotnet-backend/",
                    ],
                    ValidAudiences = [oAuthConfiguration.Audience],
                    ClockSkew = TimeSpan.Zero,
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception is SecurityTokenExpiredException)
                        {
                            context.Response.Headers.Append("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    },
                };
            });

        services.AddAuthorization();
        return services;
    }

    private static IServiceCollection AddCurrentUser(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        // services.AddScoped<ICurrentUserService, CurrentUserService>();

        return services;
    }
}
