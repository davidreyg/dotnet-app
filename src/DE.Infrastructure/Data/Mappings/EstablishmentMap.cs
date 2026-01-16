using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class EstablishmentMap : ClassMap<Establishment>
{
    public EstablishmentMap()
    {
        // Map(m => m.C).Name("Id_Pais");
        Map(m => m.Name).Name("Nombre_Establecimiento");
        Map(m => m.Ubigeo).Name("Ubigueo_Establecimiento");
        Map(m => m.DisaCode).Name("Codigo_Disa");
        Map(m => m.DisaName).Name("Disa");
        Map(m => m.RedCode).Name("Codigo_Red");
        Map(m => m.RedName).Name("Red");
        Map(m => m.MicroRedCode).Name("Codigo_MicroRed");
        Map(m => m.MicroRedName).Name("MicroRed");
        Map(m => m.UniqueCode).Name("Codigo_Unico");
        Map(m => m.SectorCode).Name("Codigo_Sector");
        Map(m => m.SectorDescription).Name("Descripcion_Sector");
        Map(m => m.Department).Name("Departamento");
        Map(m => m.Province).Name("Provincia");
        Map(m => m.District).Name("Distrito");
    }
}
