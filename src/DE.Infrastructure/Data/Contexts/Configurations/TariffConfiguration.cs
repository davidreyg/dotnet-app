using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class TariffConfiguration : IEntityTypeConfiguration<Tariff>
{
    public void Configure(EntityTypeBuilder<Tariff> builder)
    {
        builder.ToTable("Tariffs");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Cpms).IsRequired();
        builder.Property(b => b.Description).IsRequired();
        builder.Property(b => b.IILevel).IsRequired();
        builder.Property(b => b.IIILevel).IsRequired();
    }
}
