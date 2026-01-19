using Microsoft.Extensions.Options;
using Sieve.Models;
using Sieve.Services;

namespace DE.Infrastructure.Data.SieveConfigurations;

public class ApplicationSieveProcessor : SieveProcessor
{
    public ApplicationSieveProcessor(
        IOptions<SieveOptions> options,
        ISieveCustomSortMethods customSortMethods,
        ISieveCustomFilterMethods customFilterMethods
    )
        : base(options, customSortMethods, customFilterMethods) { }

    protected override SievePropertyMapper MapProperties(SievePropertyMapper mapper)
    {
        return mapper.ApplyConfigurationsFromAssembly(typeof(ApplicationSieveProcessor).Assembly);
    }
}
