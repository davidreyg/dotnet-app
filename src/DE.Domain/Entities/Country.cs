namespace DE.Domain.Entities;

public class Country
{
    public int Id { get; set; }
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}
