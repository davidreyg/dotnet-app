namespace DE.Api.Configuration;

public class InfisicalConfiguration
{
    public string SectionName = "Infisical";

    /// <summary>
    ///  Infisical URL Instance (ej: https://app.infisical.com)
    /// </summary>
    public string SiteUrl { get; set; } = string.Empty;

    /// <summary>
    /// Client ID de tu Universal Auth Machine Identity
    /// </summary>
    public string ClientId { get; set; } = string.Empty;

    /// <summary>
    /// Client Secret de tu Universal Auth Machine Identity
    /// </summary>
    public string ClientSecret { get; set; } = string.Empty;

    /// <summary>
    /// Project ID en Infisical
    /// </summary>
    public string ProjectId { get; set; } = string.Empty;

    /// <summary>
    /// Environment (development, staging, production)
    /// </summary>
    public string Environment { get; set; } = string.Empty;

    /// <summary>
    /// Secret Path (Route) (default: "/")
    /// </summary>
    public string SecretPath { get; set; } = string.Empty;

    /// <summary>
    /// Can load recursively
    /// </summary>
    public bool Recursive { get; set; } = true;

    /// <summary>
    /// Should expand references (IMPORTANT!)
    /// </summary>
    public bool ExpandSecretReferences { get; set; } = true;
}
