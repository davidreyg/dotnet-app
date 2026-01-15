using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class FinancierConfiguration : IEntityTypeConfiguration<Financier>
{
    public void Configure(EntityTypeBuilder<Financier> builder)
    {
        builder.ToTable(
            "Financiers",
            t =>
            {
                t.HasCheckConstraint("CK_Financier_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasMaxLength(100);
    }
}
