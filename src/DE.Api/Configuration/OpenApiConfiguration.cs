namespace DE.Api.Configuration;

public class OpenApiConfiguration
{
    public const string SectionName = "OpenApi";
    public string Title { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Scalar Scalar { get; set; } = new();
    public Contact Contact { get; set; } = new();
    public License License { get; set; } = new();
}

public class Scalar
{
    public string RoutePrefix { get; set; } = string.Empty;
    public string Theme { get; set; } = string.Empty;
    public bool ShowSidebar { get; set; } = true;
    public bool DarkMode { get; set; } = true;
}

public class Contact
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

public class License
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
