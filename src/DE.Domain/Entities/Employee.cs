namespace DE.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public int DocumentTypeCode { get; set; }
    public string DocumentNumber { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string MotherLastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }

    // (Foreign Keys)
    public int ContractTypeCode { get; set; }
    public int ProfessionCode { get; set; }
    public int ProfessionalCouncilCode { get; set; }
    public string? LicenseNumber { get; set; }
    public int EstablishmentCode { get; set; }

    // FIXME: Wrong format
    public DateTime HireDate { get; set; }
    public DateTime? TerminationDate { get; set; }
}
