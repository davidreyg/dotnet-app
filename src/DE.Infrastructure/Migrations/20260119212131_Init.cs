using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Id);
                    table.CheckConstraint("CK_ContractType_Code_Positive", "[Code] > 0");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    DocumentTypeCode = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    ContractTypeCode = table.Column<int>(type: "int", nullable: false),
                    ProfessionCode = table.Column<int>(type: "int", nullable: false),
                    ProfessionalCouncilCode = table.Column<int>(type: "int", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstablishmentCode = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Establishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ubigeo = table.Column<int>(type: "int", nullable: false),
                    DisaCode = table.Column<int>(type: "int", nullable: true),
                    DisaName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RedCode = table.Column<int>(type: "int", nullable: true),
                    RedName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MicroRedCode = table.Column<int>(type: "int", nullable: true),
                    MicroRedName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UniqueCode = table.Column<int>(type: "int", nullable: false),
                    SectorCode = table.Column<int>(type: "int", nullable: false),
                    SectorDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    District = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establishments", x => x.Id);
                    table.CheckConstraint("CK_Establishment_DisaCode_Positive", "[DisaCode] > -1");
                    table.CheckConstraint("CK_Establishment_MicroRedCode_Positive", "[MicroRedCode] > -1");
                    table.CheckConstraint("CK_Establishment_RedCode_Positive", "[RedCode] > -1");
                    table.CheckConstraint("CK_Establishment_SectorCode_Positive", "[SectorCode] > -1");
                    table.CheckConstraint("CK_Establishment_Ubigeo_Positive", "[Ubigeo] > 0");
                    table.CheckConstraint("CK_Establishment_UniqueCode_Positive", "[UniqueCode] > -1");
                });

            migrationBuilder.CreateTable(
                name: "Ethnicities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ethnicities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraConditions", x => x.Id);
                    table.CheckConstraint("CK_ExtraCondition_Code_Positive", "[Code] > 0");
                });

            migrationBuilder.CreateTable(
                name: "Financiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiers", x => x.Id);
                    table.CheckConstraint("CK_Financier_Code_Positive", "[Code] > 0");
                });

            migrationBuilder.CreateTable(
                name: "HealthServiceUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthServiceUnits", x => x.Id);
                    table.CheckConstraint("CK_HealthServiceUnit_Code_Positive", "[Code] > 0");
                });

            migrationBuilder.CreateTable(
                name: "HisAttentions",
                columns: table => new
                {
                    AppointmentId = table.Column<long>(type: "bigint", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Batch = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumPag = table.Column<int>(type: "int", nullable: false),
                    NumReg = table.Column<int>(type: "int", nullable: false),
                    HealthServiceUnitCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EstablishmentCode = table.Column<int>(type: "int", nullable: false),
                    Renipress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EducationalInstitutionCode = table.Column<int>(type: "int", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistrarId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FinancierCode = table.Column<int>(type: "int", nullable: false),
                    AgeReg = table.Column<int>(type: "int", nullable: false),
                    AgeType = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    PatientCurrentYear = table.Column<int>(type: "int", nullable: false),
                    PatientCurrentMonth = table.Column<int>(type: "int", nullable: false),
                    PatientCurrentDay = table.Column<int>(type: "int", nullable: false),
                    RiskGroupDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PregnancyCondition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrePregnancyWeight = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ShiftId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiagnosisType = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    LabValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CorrelativeId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LabCorrelativeId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DoseId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Height = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    Hemoglobin = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: true),
                    AbdominalCircumference = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    HeadCircumference = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    LastMenstrualPeriod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HbRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HbResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    OriginApplicationId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alert = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisAttentions", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityDocumentTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GuidCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityDocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProcedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalRecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyFolderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EthnicityCode = table.Column<int>(type: "int", nullable: false),
                    BirthUbigeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReniecUbigeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReniecAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeclaredUbigeo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentCode = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalCouncils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalCouncils", x => x.Id);
                    table.UniqueConstraint("AK_ProfessionalCouncils_Code", x => x.Code);
                    table.CheckConstraint("CK_ProfessionalCouncil_Code_Positive", "[Code] > -1");
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProfessionalCouncilCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.CheckConstraint("CK_Profession_Code_Positive", "[Code] > 0");
                });

            migrationBuilder.CreateTable(
                name: "SisProcedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SisProcedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tariffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IILevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IIILevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariffs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Establishments");

            migrationBuilder.DropTable(
                name: "Ethnicities");

            migrationBuilder.DropTable(
                name: "ExtraConditions");

            migrationBuilder.DropTable(
                name: "Financiers");

            migrationBuilder.DropTable(
                name: "HealthServiceUnits");

            migrationBuilder.DropTable(
                name: "HisAttentions");

            migrationBuilder.DropTable(
                name: "IdentityDocumentTypes");

            migrationBuilder.DropTable(
                name: "MedicalProcedures");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "ProfessionalCouncils");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "SisProcedures");

            migrationBuilder.DropTable(
                name: "Tariffs");
        }
    }
}
