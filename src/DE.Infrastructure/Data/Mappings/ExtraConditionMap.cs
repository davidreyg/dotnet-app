using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class ExtraConditionMap : ClassMap<ExtraCondition>
{
    public ExtraConditionMap()
    {
        Map(m => m.Code).Name("Id_Otra_Condicion");
        Map(m => m.Description).Name("Descripcion_Otra_Condicion");
    }
}
