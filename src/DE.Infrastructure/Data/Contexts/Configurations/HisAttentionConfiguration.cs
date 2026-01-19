using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class HisAttentionConfiguration : IEntityTypeConfiguration<HisAttention>
{
    public void Configure(EntityTypeBuilder<HisAttention> builder)
    {
        // Table Mapping
        builder.ToTable("HisAttentions");

        // Primary Key
        builder.HasKey(e => e.AppointmentId);

        // Properties Mapping & Constraints
        builder.Property(e => e.AppointmentId).ValueGeneratedNever(); // Asumiendo que viene de otro sistema/proceso

        builder
            .Property(e => e.AttendanceDate)
            .HasMaxLength(10) // Formato YYYY-MM-DD
            .IsRequired();

        builder.Property(e => e.Batch).HasMaxLength(20).IsRequired();

        builder
            .Property(e => e.HealthServiceUnitCode)
            .HasMaxLength(20) // UPS Code
            .IsRequired();

        builder.Property(e => e.Renipress).HasMaxLength(15).IsRequired();

        // Subjects
        builder.Property(e => e.PatientCode).HasMaxLength(50).IsRequired();

        builder.Property(e => e.EmployeeCode).HasMaxLength(50).IsRequired();

        builder.Property(e => e.RegistrarId).HasMaxLength(50).IsRequired();

        // Clinical Variables
        builder
            .Property(e => e.AgeType)
            .HasMaxLength(1) // D, M, A
            .IsFixedLength();

        builder.Property(e => e.RiskGroupDescription).HasMaxLength(255);

        builder.Property(e => e.PregnancyCondition).HasMaxLength(50);

        // Precision para Biometría (Decimal 5,2 o 18,2 según criticidad)
        builder.Property(e => e.PrePregnancyWeight).HasPrecision(5, 2);
        builder.Property(e => e.Weight).HasPrecision(5, 2);
        builder.Property(e => e.Height).HasPrecision(5, 2);
        builder.Property(e => e.Hemoglobin).HasPrecision(4, 2);
        builder.Property(e => e.AbdominalCircumference).HasPrecision(5, 2);
        builder.Property(e => e.HeadCircumference).HasPrecision(5, 2);

        // Encounter & Procedures
        builder
            .Property(e => e.ItemCode)
            .HasMaxLength(20) // CPT o CIE-10
            .IsRequired();

        builder
            .Property(e => e.DiagnosisType)
            .HasMaxLength(1) // P, D, R
            .IsFixedLength();

        builder.Property(e => e.LabValue).HasMaxLength(50);

        builder.Property(e => e.CorrelativeId).HasMaxLength(20);

        builder.Property(e => e.LabCorrelativeId).HasMaxLength(20);

        builder.Property(e => e.DoseId).HasMaxLength(10);

        // System & Audit
        builder.Property(e => e.OriginApplicationId).HasMaxLength(50);

        builder.Property(e => e.Alert).HasMaxLength(500);

        builder.Property(e => e.CreatedAt);
    }
}
