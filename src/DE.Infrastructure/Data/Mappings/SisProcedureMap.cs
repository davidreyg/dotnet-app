using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class SisProcedureMap : ClassMap<SisProcedure>
{
    public SisProcedureMap()
    {
        Map(m => m.Code).Name("Codigo");
        Map(m => m.Name).Name("Nombre");
    }
}
