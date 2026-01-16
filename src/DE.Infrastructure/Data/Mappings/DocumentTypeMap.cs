using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class DocumentTypeMap : ClassMap<DocumentType>
{
    public DocumentTypeMap()
    {
        Map(m => m.Code).Name("Id_Tipo_Documento");
        Map(m => m.Abbreviation).Name("Abrev_Tipo_Doc");
        Map(m => m.Description).Name("Descripcion_Tipo_Documento");
    }
}
