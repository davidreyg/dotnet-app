using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class EmployeeMap : ClassMap<Employee>
{
    public EmployeeMap()
    {
        // Map(m => m.C).Name("Id_Pais");
        Map(m => m.Code).Name("Id_Personal");
        Map(m => m.DocumentTypeCode).Name("Id_Tipo_Documento");
        Map(m => m.DocumentNumber).Name("Numero_Documento");
        Map(m => m.LastName).Name("Apellido_Paterno_Personal");
        Map(m => m.MotherLastName).Name("Apellido_Materno_Personal");
        Map(m => m.FirstName).Name("Nombres_Personal");
        Map(m => m.BirthDate).Name("Fecha_Nacimiento");
        Map(m => m.ContractTypeCode).Name("Id_Condicion");
        Map(m => m.ProfessionCode).Name("Id_Profesion");
        Map(m => m.ProfessionalCouncilCode).Name("Id_Colegio");
        Map(m => m.LicenseNumber).Name("Numero_Colegiatura");
        Map(m => m.EstablishmentCode).Name("Id_Establecimiento");
        Map(m => m.HireDate).Name("Fecha_Alta");
        Map(m => m.TerminationDate).Name("Fecha_Baja");
    }
}
