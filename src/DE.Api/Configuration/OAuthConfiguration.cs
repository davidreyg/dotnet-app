using System;

namespace DE.Api.Configuration;

public class OAuthConfiguration
{
    public const string SectionName = "OAuth";

    public string Authority => string.Empty;
    public string Audience => string.Empty;
    public string MetadataAddress => string.Empty;
    public bool RequireHttpsMetadata => true;
    public string ValidIssuer => string.Empty;
    public string AuthorizationUrl => string.Empty;
    public string TokenUrl => string.Empty;
}
