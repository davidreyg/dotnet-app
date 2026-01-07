using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations
{
    public class UpsConfiguration : IEntityTypeConfiguration<Ups>
    {
        public void Configure(EntityTypeBuilder<Ups> builder)
        {
            builder.ToTable("Ups");
            builder.HasKey(t => t.Id);

            builder.Property(b => b.Descripcion).IsRequired().HasColumnType("nvarchar(100)");
        }
    }
}
