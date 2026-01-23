using DE.Domain.Entities;
using Sieve.Services;

namespace DE.Infrastructure.Data.SieveConfigurations.Configurations;

public class AttentionSieveConfiguration : ISieveConfiguration
{
    public void Configure(SievePropertyMapper mapper)
    {
        mapper.Property<Attention>(p => p.Year).CanFilter();
        mapper.Property<Attention>(p => p.Month).CanFilter();
        mapper.Property<Attention>(p => p.HealthServiceUnitCode).CanFilter().HasName("ups");
    }
}
