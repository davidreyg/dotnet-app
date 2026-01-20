namespace DE.Domain.Entities;

public class Patient
{
    // Identifiers
    public long Id { get; set; } = default!; // Id_Paciente
    public int DocumentTypeId { get; set; } // Id_Tipo_Documento
    public string DocumentNumber { get; set; } = default!; // Numero_Documento
    public string MedicalRecordNumber { get; set; } = default!; // Historia_Clinica
    public string? FamilyFolderNumber { get; set; } = default!; // Ficha_Familiar

    // Personal Information
    public string FirstName { get; set; } = default!; // Nombres_Paciente
    public string LastName { get; set; } = default!; // Apellido_Paterno_Paciente
    public string MotherLastName { get; set; } = default!; // Apellido_Materno_Paciente
    public DateTime? BirthDate { get; set; } // Fecha_Nacimiento
    public string Gender { get; set; } = default!; // Genero (M/F)
    public int EthnicityCode { get; set; } // Id_Etnia

    // Location & Addresses
    public string BirthUbigeo { get; set; } = default!; // Ubigeo_Nacimiento
    public string ReniecUbigeo { get; set; } = default!; // Ubigeo_Reniec (Ubigeo oficial)
    public string ReniecAddress { get; set; } = default!; // Domicilio_Reniec
    public string? DeclaredUbigeo { get; set; } = default!; // Ubigeo_Declarado
    public string? DeclaredAddress { get; set; } = default!; // Domicilio_Declarado
    public string? AddressReference { get; set; } = default!; // Referencia_Domicilio

    // System & Audit
    public string CountryCode { get; set; } = default!; // Id_Pais
    public int EstablishmentCode { get; set; } // Id_Establecimiento
    public DateTime? HireDate { get; set; } // Fecha_Alta
    public DateTime? UpdatedAt { get; set; } // Fecha_Modificacion
}
