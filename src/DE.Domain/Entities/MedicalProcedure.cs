namespace DE.Domain.Entities;

public class MedicalProcedure
{
    public int Id { get; set; }
    public double Code { get; set; }
    public string Description { get; set; } = default!;
}
