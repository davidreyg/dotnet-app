namespace DE.Domain.Entities;

public class Profession
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Description { get; set; } = default!;

    // Foreign Key
    public int ProfessionalCouncilCode { get; set; }
    public ProfessionalCouncil ProfessionalCouncil { get; set; } = null!;
}
