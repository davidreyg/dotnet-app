namespace DE.Application.DTOs.Request;

public class HealthServiceUnitRequest
{
    public long Id { get; set; } = default!;
    public int Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}
