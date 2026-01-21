namespace DE.Domain.Entities;

public class Attention
{
    public long Id { get; set; }
    public long AppointmentId { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public string AttendanceDate { get; set; } = default!;
    public string Batch { get; set; } = default!;
    public int NumPag { get; set; }
    public int NumReg { get; set; }
    public int HealthServiceUnitCode { get; set; } = default!;
    public int EstablishmentCode { get; set; }
    public string PatientCode { get; set; } = default!;
    public string EmployeeCode { get; set; } = default!;
    public int RegistrarCode { get; set; } = default!;
    public int FinancierCode { get; set; }
    public string EstablishmentConditionCode { get; set; } = default!;
    public string ServiceConditionCode { get; set; } = default!;
    public int AgeReg { get; set; }
    public string AgeType { get; set; } = default!; // D, M, A
    public int PatientCurrentYear { get; set; }
    public int PatientCurrentMonth { get; set; }
    public int PatientCurrentDay { get; set; }
    public string ShiftId { get; set; } = default!;
    public string ItemCode { get; set; } = default!; // CPT / CIE-10
    public string DiagnosisType { get; set; } = default!; // P, D, R
    public string? LabValue { get; set; } = default!;
    public int CorrelativeId { get; set; } = default!;
    public int LabCorrelativeId { get; set; } = default!;
    public decimal? Weight { get; set; }
    public decimal? Height { get; set; }
    public decimal? Hemoglobin { get; set; }
    public decimal? AbdominalCircumference { get; set; }
    public decimal? HeadCircumference { get; set; }
    public int? OtherConditionCode { get; set; }
    public int? SettlementCode { get; set; }
    public DateTime? LastMenstrualPeriod { get; set; }
    public DateTime? HbRequestDate { get; set; }
    public DateTime? HbResultDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string CountryCode { get; set; } = default!;
    public string? RiskGroupDescription { get; set; } = default!;
    public string? PregnancyCondition { get; set; } = default!;
    public decimal? PrePregnancyWeight { get; set; }
    public int? DoseId { get; set; } = default!;
    public int Renipress { get; set; } = default!;
    public string? EducationalInstitutionCode { get; set; } = default!;
    public int OriginApplicationCode { get; set; } = default!;
    public string? Alert { get; set; } = default!;
}
