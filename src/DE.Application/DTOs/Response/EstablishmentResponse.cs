namespace DE.Application.DTOs.Response;

public class EstablishmentResponse
{
    public int Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public int Ubigeo { get; set; } = default!;
    public int DisaCode { get; set; } = default!;
    public string DisaName { get; set; } = default!;
    public int RedCode { get; set; } = default!;
    public string RedName { get; set; } = default!;
    public int MicroRedCode { get; set; } = default!;
    public string MicroRedName { get; set; } = default!;
    public int UniqueCode { get; set; } = default!;
    public int SectorCode { get; set; } = default!;
    public string SectorDescription { get; set; } = default!;
    public string Department { get; set; } = default!;
    public string Province { get; set; } = default!;
    public string District { get; set; } = default!;
}
