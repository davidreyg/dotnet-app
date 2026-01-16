using System.Reflection;
using DE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DE.Infrastructure.Data.Contexts
{
    public partial class DbContextApp : DbContext
    {
        public DbContextApp(DbContextOptions<DbContextApp> options)
            : base(options) { }

        public DbSet<IdentityDocumentType> IdentityDocumentType { get; set; } = default!;
        public DbSet<HealthServiceUnit> HealthServiceUnit { get; set; } = default!;
        public DbSet<MedicalProcedure> MedicalProcedure { get; set; } = default!;
        public DbSet<ProfessionalCouncil> ProfessionalCouncil { get; set; } = default!;
        public DbSet<ContractType> ContractType { get; set; } = default!;
        public DbSet<Establishment> Establishment { get; set; } = default!;
        public DbSet<Ethnicity> Ethnicity { get; set; } = default!;
        public DbSet<Financier> Financier { get; set; } = default!;
        public DbSet<ExtraCondition> ExtraCondition { get; set; } = default!;
        public DbSet<Country> Country { get; set; } = default!;
        public DbSet<Profession> Profession { get; set; } = default!;
        public DbSet<SisProcedure> SisProcedure { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Tariff> Tariff { get; set; } = default!;
        public DbSet<DocumentType> DocumentType { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //
        }
    }
}
