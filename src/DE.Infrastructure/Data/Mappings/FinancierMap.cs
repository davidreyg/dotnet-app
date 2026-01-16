using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class FinancierMap : ClassMap<Financier>
{
    public FinancierMap()
    {
        Map(m => m.Code).Name("Id_Financiador");
        Map(m => m.Description).Name("Descripcion_Financiador");
    }
}
