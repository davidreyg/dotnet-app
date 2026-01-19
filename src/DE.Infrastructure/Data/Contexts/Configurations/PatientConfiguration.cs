using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.ToTable("Patients");
        builder.HasKey(t => t.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        // Properties Mapping & Constraints
        // builder.Property(e => e.DocumentTypeId).IsRequired();
        // builder.Property(b => b.DocumentNumber).IsRequired();
        // builder.Property(b => b.LastName).IsRequired().HasMaxLength(255);
        // builder.Property(b => b.MotherLastName).IsRequired().HasMaxLength(255);
        // builder.Property(b => b.FirstName).IsRequired().HasMaxLength(255);
        // builder.Property(b => b.BirthDate).IsRequired();
        // builder.Property(b => b.Gender).IsRequired();
        // builder.Property(b => b.EthnicityCode).IsRequired();
        // builder.Property(b => b.MedicalRecordNumber).IsRequired();
        // builder.Property(b => b.FamilyFolderNumber).IsRequired();
        // builder.Property(b => b.BirthUbigeo).IsRequired();
        // builder.Property(b => b.ReniecUbigeo).IsRequired();
        // builder.Property(b => b.ReniecAddress).IsRequired();
        // builder.Property(b => b.DeclaredUbigeo);
        // builder.Property(b => b.DeclaredAddress);
        // builder.Property(b => b.AddressReference);
        // builder.Property(b => b.CountryCode).IsRequired();
        // builder.Property(b => b.EstablishmentCode).IsRequired();
        // builder.Property(b => b.HireDate);
        // builder.Property(b => b.UpdatedAt);
    }
}
