using System;

namespace DE.Domain.Entities;

public class ProfessionalCouncil
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Description { get; set; } = default!;
}
