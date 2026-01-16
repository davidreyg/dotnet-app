using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class SisProcedureConfiguration : IEntityTypeConfiguration<SisProcedure>
{
    public void Configure(EntityTypeBuilder<SisProcedure> builder)
    {
        builder.ToTable("SisProcedures");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Name).IsRequired();
    }
}
