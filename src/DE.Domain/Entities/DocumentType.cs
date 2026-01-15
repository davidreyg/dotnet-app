namespace DE.Domain.Entities;

public class DocumentType
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Abbreviation { get; set; } = default!;
    public string Description { get; set; } = default!;
}
