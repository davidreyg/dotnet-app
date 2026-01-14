using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class CpmsConfiguration
{
    public void Configure(EntityTypeBuilder<Cpms> builder)
    {
        builder.ToTable(
            "Cpms",
            t =>
            {
                t.HasCheckConstraint("CK_Cpms_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
