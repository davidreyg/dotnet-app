using System;

namespace DE.Application.DTOs.Response;

public class ProfessionResponse
{
    public long Id { get; set; } = default!;
    public int Code { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int ProfessionalCouncilCode { get; set; } = default!;
}
