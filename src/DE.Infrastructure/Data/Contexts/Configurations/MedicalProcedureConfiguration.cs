using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class MedicalProcedureConfiguration
{
    public void Configure(EntityTypeBuilder<MedicalProcedure> builder)
    {
        builder.ToTable(
            "MedicalProcedure",
            t =>
            {
                t.HasCheckConstraint("CK_MedicalProcedure_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
