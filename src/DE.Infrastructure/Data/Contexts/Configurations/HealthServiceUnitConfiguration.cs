using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations
{
    public class HealthServiceUnitConfiguration : IEntityTypeConfiguration<HealthServiceUnit>
    {
        public void Configure(EntityTypeBuilder<HealthServiceUnit> builder)
        {
            builder.ToTable(
                "HealthServiceUnits",
                t =>
                {
                    t.HasCheckConstraint("CK_HealthServiceUnit_Code_Positive", "[Code] > 0");
                }
            );
            builder.HasKey(t => t.Id);

            builder.Property(b => b.Code).IsRequired();
            builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
        }
    }
}
