namespace DE.Domain.Entities;

public class ContractType
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Description { get; set; } = default!;
}
