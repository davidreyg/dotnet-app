using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations
{
    public class IdentityDocumentTypeConfiguration : IEntityTypeConfiguration<IdentityDocumentType>
    {
        public void Configure(EntityTypeBuilder<IdentityDocumentType> builder)
        {
            builder.ToTable("IdentityDocumentType");
            builder.HasKey(t => t.Id);

            builder
                .Property(b => b.GuidCode)
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("NEWID()");

            builder.Property(b => b.Code).IsRequired().HasMaxLength(10);

            builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");

            builder.Property(b => b.Status).HasDefaultValue(1);

            builder.Property(b => b.IsDeleted).HasDefaultValue(false);

            builder.Property(b => b.CreatedAt).HasColumnType("datetime2");

            builder.Property(b => b.UpdatedAt).HasColumnType("datetime2");
        }
    }
}
