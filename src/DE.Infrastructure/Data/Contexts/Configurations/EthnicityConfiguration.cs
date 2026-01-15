using System;
using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class EthnicityConfiguration : IEntityTypeConfiguration<Ethnicity>
{
    public void Configure(EntityTypeBuilder<Ethnicity> builder)
    {
        builder.ToTable("Ethnicities");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Name).IsRequired().HasMaxLength(50);
    }
}
