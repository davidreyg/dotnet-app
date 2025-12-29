namespace DE.Application.DTOs.Request;

public class IdentityDocumentTypeRequest
{
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Status { get; set; }
}
