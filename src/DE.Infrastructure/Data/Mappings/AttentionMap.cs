using CsvHelper.Configuration;
using DE.Domain.Entities;

namespace DE.Infrastructure.Data.Mappings;

public class AttentionMap : ClassMap<Attention>
{
    public AttentionMap()
    {
        Map(m => m.AppointmentId).Name("Id_Cita");
        Map(m => m.Year).Name("Anio");
        Map(m => m.Month).Name("Mes");
        Map(m => m.AttendanceDate).Name("Fecha_Atencion");
        Map(m => m.Batch).Name("Lote");
        Map(m => m.NumPag).Name("Num_Pag");
        Map(m => m.NumReg).Name("Num_Reg");
        Map(m => m.HealthServiceUnitCode).Name("Id_Ups");
        Map(m => m.EstablishmentCode).Name("Id_Establecimiento");
        Map(m => m.PatientCode).Name("Id_Paciente");
        Map(m => m.EmployeeCode).Name("Id_Personal");
        Map(m => m.RegistrarCode).Name("Id_Registrador");
        Map(m => m.FinancierCode).Name("Id_Financiador");
        Map(m => m.EstablishmentConditionCode).Name("Id_Condicion_Establecimiento");
        Map(m => m.ServiceConditionCode).Name("Id_Condicion_Servicio");
        Map(m => m.AgeReg).Name("Edad_Reg");
        Map(m => m.AgeType).Name("Tipo_Edad");
        Map(m => m.PatientCurrentYear).Name("Anio_Actual_Paciente");
        Map(m => m.PatientCurrentMonth).Name("Mes_Actual_Paciente");
        Map(m => m.PatientCurrentDay).Name("Dia_Actual_Paciente");
        Map(m => m.ShiftId).Name("Id_Turno");
        Map(m => m.ItemCode).Name("Codigo_Item");
        Map(m => m.DiagnosisType).Name("Tipo_Diagnostico");
        Map(m => m.LabValue).Name("Valor_Lab").TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.CorrelativeId).Name("Id_Correlativo");
        Map(m => m.LabCorrelativeId).Name("Id_Correlativo_Lab");
        Map(m => m.Weight).Name("Peso");
        Map(m => m.Height).Name("Talla");
        Map(m => m.Hemoglobin).Name("Hemoglobina");
        Map(m => m.AbdominalCircumference).Name("Perimetro_Abdominal");
        Map(m => m.HeadCircumference).Name("Perimetro_Cefalico");
        Map(m => m.OtherConditionCode).Name("Id_Otra_Condicion");
        Map(m => m.SettlementCode).Name("Id_Centro_Poblado");
        Map(m => m.LastMenstrualPeriod).Name("Fecha_Ultima_Regla");
        Map(m => m.HbRequestDate).Name("Fecha_Solicitud_Hb");
        Map(m => m.HbResultDate).Name("Fecha_Resultado_Hb");
        Map(m => m.CreatedAt).Name("Fecha_Registro");
        Map(m => m.UpdatedAt).Name("Fecha_Modificacion");
        Map(m => m.CountryCode).Name("Id_Pais");
        Map(m => m.RiskGroupDescription)
            .Name("gruporiesgo_desc")
            .TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.PregnancyCondition)
            .Name("condicion_gestante")
            .TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.PrePregnancyWeight).Name("peso_pregestacional");
        Map(m => m.DoseId).Name("Id_dosis");
        Map(m => m.Renipress).Name("renipress");
        Map(m => m.EducationalInstitutionCode)
            .Name("Id_Institucion_Edu")
            .TypeConverterOption.NullValues(" ", string.Empty);
        Map(m => m.OriginApplicationCode).Name("Id_AplicacionOrigen");
        Map(m => m.Alert).Name("Alerta").TypeConverterOption.NullValues(" ", string.Empty);
    }
}
