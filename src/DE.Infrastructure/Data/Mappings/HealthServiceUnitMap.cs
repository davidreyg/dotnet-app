using System;
using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class HealthServiceUnitMap : ClassMap<HealthServiceUnit>
{
    public HealthServiceUnitMap()
    {
        Map(m => m.Code).Name("Id_Ups");
        Map(m => m.Description).Name("Descripcion_Ups");
    }
}
