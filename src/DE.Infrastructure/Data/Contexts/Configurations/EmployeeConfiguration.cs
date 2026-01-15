using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.DocumentNumber).IsRequired().HasMaxLength(20);
        builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.MotherLastName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.LicenseNumber).HasMaxLength(20);

        builder.Property(e => e.BirthDate).HasColumnType("date");
        builder.Property(e => e.HireDate).HasColumnType("date");
        builder.Property(e => e.TerminationDate).HasColumnType("date");

        builder.Property(b => b.DocumentTypeCode).IsRequired();
        builder.Property(b => b.ContractTypeCode).IsRequired();
        builder.Property(b => b.ProfessionCode).IsRequired();
        builder.Property(b => b.ProfessionalCouncilCode).IsRequired();
        builder.Property(b => b.EstablishmentCode).IsRequired();
    }
}
