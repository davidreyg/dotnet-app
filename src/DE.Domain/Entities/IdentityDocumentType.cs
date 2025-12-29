using DE.Domain.Common;

namespace DE.Domain.Entities;

public class IdentityDocumentType : BaseAuditableEntity
{
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}
