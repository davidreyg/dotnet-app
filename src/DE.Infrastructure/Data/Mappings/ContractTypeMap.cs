using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class ContractTypeMap : ClassMap<ContractType>
{
    public ContractTypeMap()
    {
        Map(m => m.Code).Name("Id_Condicion");
        Map(m => m.Description).Name("Descripcion_Condicion");
    }
}
