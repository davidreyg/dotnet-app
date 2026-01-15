namespace DE.Domain.Entities;

public class Tariff
{
    public int Id { get; set; }
    public string Cpms { get; set; } = default!;
    public string Description { get; set; } = default!;

    public string IILevel { get; set; } = default!;
    public string IIILevel { get; set; } = default!;
}
