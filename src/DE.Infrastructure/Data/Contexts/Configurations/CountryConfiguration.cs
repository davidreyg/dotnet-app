using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired().HasMaxLength(10);
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
