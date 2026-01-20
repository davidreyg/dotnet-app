using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class PatientMap : ClassMap<Patient>
{
    public PatientMap()
    {
        Map(m => m.Id).Name("Id_Paciente");
        Map(m => m.DocumentTypeId).Name("Id_Tipo_Documento");
        Map(m => m.DocumentNumber).Name("Numero_Documento");
        Map(m => m.LastName).Name("Apellido_Paterno_Paciente");
        Map(m => m.MotherLastName).Name("Apellido_Materno_Paciente");
        Map(m => m.FirstName).Name("Nombres_Paciente");
        Map(m => m.BirthDate)
            .Name("Fecha_Nacimiento")
            .TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.Gender).Name("Genero");
        Map(m => m.EthnicityCode).Name("Id_Etnia");
        Map(m => m.MedicalRecordNumber).Name("Historia_Clinica");
        Map(m => m.FamilyFolderNumber).Name("Ficha_Familiar");
        Map(m => m.BirthUbigeo).Name("Ubigeo_Nacimiento");
        Map(m => m.ReniecUbigeo).Name("Ubigeo_Reniec");
        Map(m => m.ReniecAddress).Name("Domicilio_Reniec");
        Map(m => m.DeclaredUbigeo).Name("Ubigeo_Declarado");
        Map(m => m.DeclaredAddress).Name("Domicilio_Declarado");
        Map(m => m.AddressReference).Name("Referencia_Domicilio");
        Map(m => m.CountryCode).Name("Id_Pais");
        Map(m => m.EstablishmentCode).Name("Id_Establecimiento");
        Map(m => m.HireDate).Name("Fecha_Alta").TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.UpdatedAt)
            .Name("Fecha_Modificacion")
            .TypeConverterOption.NullValues(" ", string.Empty);
        ;
    }
}
