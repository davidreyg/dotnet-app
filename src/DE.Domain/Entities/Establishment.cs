namespace DE.Domain.Entities;

public class Establishment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Ubigeo { get; set; }
    public int? DisaCode { get; set; }
    public string? DisaName { get; set; } = string.Empty;
    public int? RedCode { get; set; }
    public string? RedName { get; set; } = string.Empty;
    public int? MicroRedCode { get; set; }
    public string? MicroRedName { get; set; } = string.Empty;
    public int UniqueCode { get; set; }
    public int SectorCode { get; set; }
    public string SectorDescription { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Province { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
}
