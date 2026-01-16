using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class MedicalProcedureMap : ClassMap<MedicalProcedure>
{
    public MedicalProcedureMap()
    {
        Map(m => m.Code).Name("Codigo_Item");
        Map(m => m.Description).Name("Descripcion_Item");
    }
}
