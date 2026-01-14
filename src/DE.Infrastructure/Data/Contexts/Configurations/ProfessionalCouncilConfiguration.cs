using System;
using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class ProfessionalCouncilConfiguration : IEntityTypeConfiguration<ProfessionalCouncil>
{
    public void Configure(EntityTypeBuilder<ProfessionalCouncil> builder)
    {
        builder.ToTable(
            "ProfessionalCouncils",
            t =>
            {
                t.HasCheckConstraint("CK_ProfessionalCouncil_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
