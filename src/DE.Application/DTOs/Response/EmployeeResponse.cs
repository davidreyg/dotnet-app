namespace DE.Application.DTOs.Response;

public class EmployeeResponse
{
    public int Id { get; set; } = default!;
    public long Code { get; set; } = default!;
    public int DocumentTypeCode { get; set; } = default!;
    public string DocumentNumber { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string MotherLastName { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public DateTime BirthDate { get; set; } = default!;

    // (Foreign Keys)
    public int ContractTypeCode { get; set; } = default!;
    public int ProfessionCode { get; set; } = default!;
    public int ProfessionalCouncilCode { get; set; } = default!;
    public string? LicenseNumber { get; set; } = default!;
    public int EstablishmentCode { get; set; } = default!;

    public DateTime HireDate { get; set; } = default!;
    public DateTime? TerminationDate { get; set; } = default!;
}
