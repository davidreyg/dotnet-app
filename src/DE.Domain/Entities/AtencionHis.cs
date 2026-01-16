namespace DE.Domain.Entities;

// FIXME: Corregir Atencion HIS
public class AtencionHis
{
    // Identificadores y Control
    public long IdCita { get; set; }
    public int Anio { get; set; }
    public int Mes { get; set; }
    public int Dia { get; set; }
    public string FechaAtencion { get; set; }
    public string Lote { get; set; }
    public int NumPag { get; set; }
    public int NumReg { get; set; }

    // Ubicación y Establecimiento
    public string IdUps { get; set; }
    public int IdEstablecimiento { get; set; }
    public string Renipress { get; set; }
    public int IdInstitucionEdu { get; set; }

    // Sujetos
    public string IdPaciente { get; set; }
    public string IdPersonal { get; set; }
    public string IdRegistrador { get; set; }
    public int IdFinanciador { get; set; }

    // Variables Clínicas (Paciente)
    public int EdadReg { get; set; }
    public string TipoEdad { get; set; } // D, M, A
    public int AnioActualPaciente { get; set; }
    public int MesActualPaciente { get; set; }
    public int DiaActualPaciente { get; set; }
    public string GrupoRiesgoDesc { get; set; }
    public string CondicionGestante { get; set; }
    public decimal? PesoPregestacional { get; set; }

    // Atención y Procedimientos
    public int IdTurno { get; set; }
    public string CodigoItem { get; set; } // CPT / CIE-10
    public string TipoDiagnostico { get; set; } // P, D, R
    public string ValorLab { get; set; }
    public string IdCorrelativo { get; set; }
    public string IdCorrelativoLab { get; set; }
    public string IdDosis { get; set; }

    // Biometría
    public decimal? Peso { get; set; }
    public decimal? Talla { get; set; }
    public decimal? Hemoglobina { get; set; }
    public decimal? PerimetroAbdominal { get; set; }
    public decimal? PerimetroCefalico { get; set; }

    // Fechas Específicas
    public DateTime? FechaUltimaRegla { get; set; }
    public DateTime? FechaSolicitudHb { get; set; }
    public DateTime? FechaResultadoHb { get; set; }

    // Auditoría y Sistema
    public DateTime FechaRegistro { get; set; }
    public DateTime? FechaModificacion { get; set; }
    public int IdPais { get; set; }
    public string IdAplicacionOrigen { get; set; }
    public string Alerta { get; set; }
}
