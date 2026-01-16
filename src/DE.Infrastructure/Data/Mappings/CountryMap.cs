using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class CountryMap : ClassMap<Country>
{
    public CountryMap()
    {
        Map(m => m.Code).Name("Id_Pais");
        Map(m => m.Description).Name("Descripcion_Pais");
    }
}
