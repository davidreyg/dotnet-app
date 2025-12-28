namespace DE.Api.Configuration;

public static class OpenApiConfiguration
{
    public static string Title => "Statistic Dashboard API";
    public static string Version => "v1";
    public static string Description => "API Documentation for Statistic Dashboard Project";

    public static class Scalar
    {
        public static string RoutePrefix => "api-docs";
        public static string Theme => "purple"; // purple, blue, green, etc.
        public static bool ShowSidebar => true;
        public static bool DarkMode => true;
    }

    public static class Contact
    {
        public static string Name => "Statistic Dashboard Team";
        public static string Email => "contact@de-api.com";
        public static string Url => "https://de-api.com";
    }

    public static class License
    {
        public static string Name => "MIT";
        public static string Url => "https://opensource.org/licenses/MIT";
    }
}
