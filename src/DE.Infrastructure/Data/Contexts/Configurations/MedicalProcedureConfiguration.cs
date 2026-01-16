using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class MedicalProcedureConfiguration : IEntityTypeConfiguration<MedicalProcedure>
{
    public void Configure(EntityTypeBuilder<MedicalProcedure> builder)
    {
        builder.ToTable("MedicalProcedures");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasMaxLength(255);
    }
}
