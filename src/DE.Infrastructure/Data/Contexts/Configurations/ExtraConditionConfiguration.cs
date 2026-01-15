using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class ExtraConditionConfiguration : IEntityTypeConfiguration<ExtraCondition>
{
    public void Configure(EntityTypeBuilder<ExtraCondition> builder)
    {
        builder.ToTable(
            "ExtraConditions",
            t =>
            {
                t.HasCheckConstraint("CK_ExtraCondition_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
