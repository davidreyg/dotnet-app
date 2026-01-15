using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class ProfessionConfiguration : IEntityTypeConfiguration<Profession>
{
    public void Configure(EntityTypeBuilder<Profession> builder)
    {
        builder.ToTable(
            "Professions",
            t =>
            {
                t.HasCheckConstraint("CK_Profession_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
        builder.Property(b => b.ProfessionalCouncilCode).IsRequired();
    }
}
