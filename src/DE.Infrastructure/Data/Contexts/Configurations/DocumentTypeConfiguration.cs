using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.ToTable("DocumentTypes");
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired().HasMaxLength(10);
        builder.Property(b => b.Abbreviation).IsRequired().HasMaxLength(20);
        builder.Property(b => b.Description).IsRequired().HasMaxLength(150);
    }
}
