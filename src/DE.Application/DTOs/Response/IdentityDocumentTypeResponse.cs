namespace DE.Application.DTOs.Response;

public class IdentityDocumentTypeResponse
{
    public long Id { get; set; }
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Status { get; set; }
}

public class IdentityDocumentTypeByIdResponse
{
    public long Id { get; set; }
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}

public class IdentityDocumentTypeSelectItemResponse
{
    public long Id { get; set; }
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}
