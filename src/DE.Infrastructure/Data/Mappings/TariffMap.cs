using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class TariffMap : ClassMap<Tariff>
{
    public TariffMap()
    {
        Map(m => m.Cpms).Name("CPMS");
        Map(m => m.Description).Name("Denominacion_Procedimientos");
        Map(m => m.IILevel).Name("II_NIVEL");
        Map(m => m.IIILevel).Name("III _NIVEL");
    }
}
