namespace DE.Domain.Entities;

public class HisAttention
{
    public long AppointmentId { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public string AttendanceDate { get; set; } = default!;
    public string Batch { get; set; } = default!;
    public int NumPag { get; set; }
    public int NumReg { get; set; }

    public string HealthServiceUnitCode { get; set; } = default!;
    public int EstablishmentCode { get; set; }
    public string Renipress { get; set; } = default!;
    public int EducationalInstitutionCode { get; set; }

    // Sujetos
    public string PatientCode { get; set; } = default!;
    public string EmployeeCode { get; set; } = default!;
    public string RegistrarId { get; set; } = default!;
    public int FinancierCode { get; set; }

    // Variables Clínicas (Paciente)
    public int AgeReg { get; set; }
    public string AgeType { get; set; } = default!; // D, M, A
    public int PatientCurrentYear { get; set; }
    public int PatientCurrentMonth { get; set; }
    public int PatientCurrentDay { get; set; }
    public string RiskGroupDescription { get; set; } = default!;
    public string PregnancyCondition { get; set; } = default!;
    public decimal? PrePregnancyWeight { get; set; }

    // Atención y Procedimientos
    public int ShiftId { get; set; } //TurnoId
    public string ItemCode { get; set; } = default!; // CPT / CIE-10
    public string DiagnosisType { get; set; } = default!; // P, D, R
    public string LabValue { get; set; } = default!;
    public string CorrelativeId { get; set; } = default!;
    public string LabCorrelativeId { get; set; } = default!;
    public string DoseId { get; set; } = default!;

    // Biometría
    public decimal? Weight { get; set; }
    public decimal? Height { get; set; }
    public decimal? Hemoglobin { get; set; }
    public decimal? AbdominalCircumference { get; set; } // perimetro abdominal
    public decimal? HeadCircumference { get; set; } // perimetro cefalico

    // Fechas Específicas
    public DateTime? LastMenstrualPeriod { get; set; } //fecha ultima regla
    public DateTime? HbRequestDate { get; set; }
    public DateTime? HbResultDate { get; set; }

    // Auditoría y Sistema
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int CountryCode { get; set; }
    public string OriginApplicationId { get; set; } = default!;
    public string Alert { get; set; } = default!;
}
