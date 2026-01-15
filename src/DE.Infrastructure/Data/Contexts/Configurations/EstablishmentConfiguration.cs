using System;
using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class EstablishmentConfiguration : IEntityTypeConfiguration<Establishment>
{
    public void Configure(EntityTypeBuilder<Establishment> builder)
    {
        builder.ToTable(
            "Establishments",
            t =>
            {
                t.HasCheckConstraint("CK_Establishment_Ubigeo_Positive", "[Ubigeo] > 0");
                t.HasCheckConstraint("CK_Establishment_DisaCode_Positive", "[DisaCode] > 0");
                t.HasCheckConstraint("CK_Establishment_RedCode_Positive", "[RedCode] > 0");
                t.HasCheckConstraint(
                    "CK_Establishment_MicroRedCode_Positive",
                    "[MicroRedCode] > 0"
                );
                t.HasCheckConstraint("CK_Establishment_UniqueCode_Positive", "[UniqueCode] > 0");
                t.HasCheckConstraint("CK_Establishment_SectorCode_Positive", "[SectorCode] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name).IsRequired().HasMaxLength(255);
        builder.Property(t => t.Ubigeo).IsRequired();
        builder.Property(t => t.DisaCode).IsRequired();
        builder.Property(t => t.DisaName).IsRequired().HasMaxLength(150);
        builder.Property(t => t.RedCode).IsRequired();
        builder.Property(t => t.RedName).IsRequired().HasMaxLength(150);
        builder.Property(t => t.MicroRedCode).IsRequired();
        builder.Property(t => t.MicroRedName).IsRequired().HasMaxLength(150);
        builder.Property(t => t.UniqueCode).IsRequired();
        builder.Property(t => t.SectorCode).IsRequired();
        builder.Property(t => t.SectorDescription).IsRequired().HasMaxLength(150);
        builder.Property(t => t.Department).IsRequired().HasMaxLength(255);
        builder.Property(t => t.Province).IsRequired().HasMaxLength(255);
        builder.Property(t => t.District).IsRequired().HasMaxLength(255);
    }
}
