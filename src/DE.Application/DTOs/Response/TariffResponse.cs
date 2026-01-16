namespace DE.Application.DTOs.Response;

public class TariffResponse
{
    public int Id { get; set; } = default!;
    public string Cpms { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string IILevel { get; set; } = default!;
    public string IIILevel { get; set; } = default!;
}
