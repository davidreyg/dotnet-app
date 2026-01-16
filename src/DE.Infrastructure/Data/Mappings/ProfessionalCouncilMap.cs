using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class ProfessionalCouncilMap : ClassMap<ProfessionalCouncil>
{
    public ProfessionalCouncilMap()
    {
        Map(m => m.Code).Name("Id_Colegio");
        Map(m => m.Description).Name("Descripcion_Colegio");
    }
}
