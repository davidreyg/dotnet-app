using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class EthnicityMap : ClassMap<Ethnicity>
{
    public EthnicityMap()
    {
        // Map(m => m).Name("Id_Pais");
        Map(m => m.Name).Name("Descripcion_Etnia");
    }
}
