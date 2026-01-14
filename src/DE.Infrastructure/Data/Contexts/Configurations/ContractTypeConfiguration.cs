using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DE.Infrastructure.Data.Contexts.Configurations;

public class ContractTypeConfiguration : IEntityTypeConfiguration<ContractType>
{
    public void Configure(EntityTypeBuilder<ContractType> builder)
    {
        builder.ToTable(
            "ContractTypes",
            t =>
            {
                t.HasCheckConstraint("CK_ContractType_Code_Positive", "[Code] > 0");
            }
        );
        builder.HasKey(t => t.Id);

        builder.Property(b => b.Code).IsRequired();
        builder.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(100)");
    }
}
