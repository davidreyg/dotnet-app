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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //
        }
    }
}
