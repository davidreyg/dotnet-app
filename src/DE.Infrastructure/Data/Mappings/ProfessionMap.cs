using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class ProfessionMap : ClassMap<Profession>
{
    public ProfessionMap()
    {
        Map(m => m.Code).Name("Id_Profesion");
        Map(m => m.Description).Name("Descripcion_Profesion");
        Map(m => m.ProfessionalCouncilCode).Name("Id_Colegio");
    }
}
